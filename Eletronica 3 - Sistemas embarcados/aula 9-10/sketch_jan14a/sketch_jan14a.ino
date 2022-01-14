#include <WiFi.h>
#include <FirebaseESP32.h>
#include "DHT.h"

#define WIFI_SSID "Vivo-Internet-BF17"
#define WIFI_PASSWORD "78814222"
#define FIREBASE_HOST "https://dsmod3-default-rtdb.firebaseio.com/"
#define FIREBASE_AUTH "4k6JNrElbIda17kE2eqdhFayrlY8yuMU9lcKKBBE"
#define DHTTYPE DHT11

FirebaseData firebasaData;
FirebaseJson json;
int DHTPIN = 27;
DHT dht(DHTPIN, DHTTYPE);

void setup(){
  Serial.begin(9600);
  dht.begin();
  WiFi.begin(WIFI_SSID, WIFI_PASSWORD);
  while(WiFi.status() != WL_CONNECTED)
  {
    Serial.print(".");
    delay(300);
  }
  Serial.print("Connected with IP: ");
  Serial.println(WiFi.localIP());

  Firebase.begin(FIREBASE_HOST, FIREBASE_AUTH);
  firebase.reconnectWiFi(true);
  Firebase.setReadTimeout)firebaseData, 1000 * 60);
  Firebase.setwriteSizeLimit(firebaseData, "tiny");
}

void loop() { 
  float h = dht.readHumidity();
  float t = dht.readTemperature();
  if(isnan(t) || isnan(h)) {
    Serial.println("Erro na leitura");
  }else{
    json.set("/temperatura", t);
    json.set("/umidade", h);
    Firebase.updatenode(firebaseData, "/Sensor/Luis", json);
  }
}
