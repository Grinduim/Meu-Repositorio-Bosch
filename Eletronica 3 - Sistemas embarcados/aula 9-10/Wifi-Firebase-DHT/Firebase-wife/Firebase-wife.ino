
#include <FirebaseESP32.h>

#include <DHT.h>
#include <DHT_U.h>


#include <WiFi.h>

#define DHTPIN 33
#define DHTTYPE DHT11
DHT dht(DHTPIN, DHTTYPE);

//#define WIFI_SSID "Vivo-Internet-BF17"
//#define WIFI_PASSWORD "78814222"
#define WIFI_SSID "Galaxy A318713"
#define WIFI_PASSWORD "12345678"
#define FIREBASE_HOST "https://vinicius-dht-default-rtdb.firebaseio.com/" // url da minha pasta
#define FIREBASE_AUTH "bhEyR05TWfHyXoAzSHgiCj0MfQbdDFsfPTPmxVxB" // token de auth
FirebaseData firebaseData;
FirebaseJson json;

void setup() {
  Serial.begin(9600);
  WiFi.begin(WIFI_SSID, WIFI_PASSWORD);
  while (WiFi.status() != WL_CONNECTED) {
    Serial.print(".");
    delay(300);
  }

  Serial.print("Connected with ip: ");
  Serial.println(WiFi.localIP());
  Firebase.begin(FIREBASE_HOST, FIREBASE_AUTH);
  Firebase.reconnectWiFi(true);
  Firebase.setReadTimeout(firebaseData, 1000 * 60);
  Firebase.setwriteSizeLimit(firebaseData, "tiny");
  dht.begin();
}



void loop() {
  float h = dht.readHumidity(); 
  float t = dht.readTemperature();
  json.set("/temperatura", t); // falando que o json é em X lugar
  json.set("/umidade", h);
  Firebase.updateNode(firebaseData, "/Sensor", json); // enviando os dados

}
