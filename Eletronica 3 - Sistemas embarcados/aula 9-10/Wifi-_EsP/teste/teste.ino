#include <WiFi.h>
#include <FirebaseESP32.h>
#include "DHT.h"

#define WIFI_PASS "78814222"
#define WIFI_SSID "Vivo-Internet-BF17"

#define FIREBASE_HOST "https://dsmod3-default-rtdb.firebaseio.com/"
#define FIREBASE_AUTH "4k6JNrElbIda17kE2eqdhFayrlY8yuMU9lcKKBBE"

#define DHTTYPE DHT11

FirebaseData firebaseData;
FirebaseJson json;

int dhtpin = 27;

DHT dht(dhtpin,DHTTYPE);


void setup() {
  // put your setup code here, to run once:
  dht.begin();
  
  WiFi.begin(WIFI_SSID,WIFI_PASS);
  Serial.begin(9600);
  while(WiFi.status() != WL_CONNECTED){
    Serial.print(".");
    delay(300);
  }
  
  Serial.print("Connected with IP: ");
  Serial.println(WiFi.localIP());

  Firebase.begin(FIREBASE_HOST, FIREBASE_AUTH);
  Firebase.reconnectWifi(true);
  Firebase.setReadTimeout(firebaseData,1000*60);
  Firebase.setwriteSizeLimit(firebaseData,"tiny");
}

void loop() {
  // put your main code here, to run repeatedly:
  float t = dht.readTemperature()
  float h = dht.readHumidity(); 
  json.set("/temperatura",t);
  json.set("/umidade",h);
  Firebase.updateNode(firebaseData,"/Sensor/Vinicius",json);
  
} 
