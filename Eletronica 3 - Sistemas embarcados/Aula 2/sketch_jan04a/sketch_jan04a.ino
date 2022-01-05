int Led1 = 2;
int Led2 = 7;
int button = 4;

void setup() {
  // put your setup code here, to run once:
  pinMode(Led1,OUTPUT);
  pinMode(Led1,OUTPUT);
  pinMode(button,INPUT_PULLUP);
  Serial.begin(9600);
}

void loop() {
  digitalWrite(Led1,LOW);
  int press = digitalRead(button);
  digitalWrite(Led2, HIGH);
  
  if( press HIGH){
    digitalWrite(Led2, LOW);
    digitalWrite(Led1,HIGH);
    delay(2000);
  }
  
}
