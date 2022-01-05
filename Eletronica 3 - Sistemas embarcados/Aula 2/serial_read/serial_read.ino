int pinButton = 4;
int i = 1;

void setup() {
  pinMode(pinButton, INPUT_PULLUP);
  Serial.begin(9600);
}

void loop() {
  int logic = digitalRead(pinButton);
  delay(1000);
  if(logic == LOW){
    Serial.print("pressionado por ");
    Serial.print(i);
    Serial.println(" segundos");
    i++;
  }else{
    i=1;
  }
}
