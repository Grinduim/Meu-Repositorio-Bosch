#include <LiquidCrystal.h>
#include "DHT.h"
#define DHTTYPE DHT11 // definindo o tipo do DHT
LiquidCrystal lcd(12,11,5,4,3,2); // definindo as portas em q estão os pinos do lcd

int DHTPIN = A1;

DHT dht(DHTPIN, DHTTYPE);

void setup() {
  // put your setup code here, to run once:
  lcd.begin(16,2);
  lcd.clear();
  dht.begin();
}

void loop() {
  // put your main code here, to run repeatedly:
  lcd.clear();
  float h = dht.readHumidity();
  float t = dht.readTemperature();
  if(isnan(t)|| isnan(h)){
    lcd.setCursor(2,0);
    lcd.print("Erro na leitura");
  }
  else{
    lcd.setCursor(0,0);
    lcd.print(F("Temperatura:"));
    lcd.print(t);
    lcd.setCursor(0,1);
    lcd.print(F("Umidade:"));
    lcd.print(h);
  }
  delay(2000);

}
