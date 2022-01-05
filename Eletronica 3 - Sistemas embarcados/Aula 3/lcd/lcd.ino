#include <LiquidCrystal.h>

LiquidCrystal lcd(12,11,5,4,3,2); // definindo as portas em q estão os pinos do lcd

void setup() {
  // put your setup code here, to run once:
  lcd.begin(16,2);
  lcd.clear();
  lcd.setCursor(2,0);
  lcd.print("Hello");
}

void loop() {
  // put your main code here, to run repeatedly:
  lcd.clear();
  lcd.setCursor(4,1);
  lcd.print("Subindo");
  delay(2000);
  lcd.clear();
  lcd.setCursor(4,0);
  lcd.print("Subindo");
  delay(2000);
  lcd.clear();
  delay(2000);

  
}
