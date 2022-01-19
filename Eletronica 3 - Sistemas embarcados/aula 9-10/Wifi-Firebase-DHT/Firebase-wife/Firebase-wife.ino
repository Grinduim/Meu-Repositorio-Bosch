#include <ESP32WiFi.h>
#include <FirebaseESP32.h>
#include <DHT.h>
#define DHTPIN 4
#define DHTTYPE DHT11
DHT dht(DHTPIN, DHTTYPE);

#define WIFI_SSID "Vivo-Internet-BF17"
#define WIFI_PASSWORD "78814222"
#define FIREBASE_HOST "https://dsmod3-default-rtdb.firebaseio.com/"
#define FIREBASE_AUTH "4k6JNrElbIda17kE2eqdhFayrlY8yuMU9lcKKBBE"

FirebaseData firebaseData;
FirebaseJson json;

void setup() {
  Serial.begin(9600);
  WiFi.begin(WIFI_SSID, WIFI_PASSWORD);
  while(WiFi.status() != WL_CONNECTED){
    Serial.print(".");
    delay(300);
  }

  Serial.print("Connected with ip: ");
  Serial.println(WiFi.localIP());
  Firebase.begin(FIREBASE_HOST,FIREBASE_AUTH);
  Firebase.reconnectWiFi(true);
  Firebase.setReadTimeout(firebaseData, 1000 * 60);
  Firebase.setwriteSizeLimit(firebaseData, "tiny");
}



void loop() {
  float h = dht.readHumidity();
  float t = dht.readTemperature();
  json.set("/temperatura", t);
  json.set("/umidade", h);
  Firebase.updateNode(firebaseData, "/Sensor/Alison", json);

}
