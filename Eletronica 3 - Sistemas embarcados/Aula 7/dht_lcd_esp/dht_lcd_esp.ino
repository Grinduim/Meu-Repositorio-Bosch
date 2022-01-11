#include <LiquidCrystal.h>
#include <DHT.h>
LiquidCrystal lcd (19,23,18,17,16,15);

int pin = 21;
DHT dht(pin, DHT11);

void setup() {
  // put your setup code here, to run once:
  dht.begin();
  lcd.begin(16,2);
  lcd.home();
}

void loop() {
  // put your main code here, to run repeatedly:
  lcd.clear();
  float h = dht.readHumidity();
  float t = dht.readTemperature();

  lcd.setCursor(1,0);
    
  if(isnan(h) || isnan(t)){
    lcd.print("Erro");
  }
  else
  {
    lcd.print("Temperatura:");
    lcd.print(t);
    lcd.setCursor(1,1);
    lcd.print("Humidade");
    lcd.print(h);
  }
  delay(3000);
}
