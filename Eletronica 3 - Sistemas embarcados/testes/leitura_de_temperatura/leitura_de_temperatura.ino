#include "DHT.h"
#define DHTTYPE DHT11 //DHT11 type
int DHTPIN = A1; // pino analogico do sens

DHT dht(DHTPIN, DHTTYPE); // instnaciando obj DHT informando os tipos

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  Serial.println("FHTxx teste!");
  dht.begin();
}

void loop() {
  // put your main code here, to run repeatedly:
  delay(5000);
  float h = dht.readHumidity(); // lendo umidade
  float t = dht.readTemperature(); //lendo temperatura
  Serial.println();
  if(isnan(t)|| isnan(h)){
    Serial.println("Failed to read From DHT!");
  }
  else {
    Serial.print("umidade:");
    Serial.print(h);
    Serial.print("Temperatura:");
    Serial.print(t);
    Serial.print(" *C");
    
  }
}
