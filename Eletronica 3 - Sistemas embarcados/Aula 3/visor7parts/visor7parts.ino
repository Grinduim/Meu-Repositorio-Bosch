int PinA = 9;
int PinB = 2;
int PinC = 3;
int PinD = 4;
int PinE = 5;
int PinF = 6;
int PinG = 7;
int PinP = 8;

void setup() {
  // put your setup code here, to run once:
  pinMode(PinA,OUTPUT);
  pinMode(PinB,OUTPUT);
  pinMode(PinC,OUTPUT);
  pinMode(PinD,OUTPUT);
  pinMode(PinE,OUTPUT);
  pinMode(PinF,OUTPUT);
  pinMode(PinG,OUTPUT);
  pinMode(PinP,OUTPUT);
  
  Serial.begin(9600);
}

void ClearLed(){
  int i = 0;
  for(i = 2; i<=9; i++){
      digitalWrite(i,LOW);
  }
}

void loop() {
// Os codigos a baixo servem para escrever i O T no Display;
  digitalWrite(PinA,HIGH);
  delay(2000);
  ClearLed();
  delay(2000);
  digitalWrite(PinB,HIGH);
  digitalWrite(PinC,HIGH);
  delay(2000);
  ClearLed();



  digitalWrite(PinC,HIGH);
  digitalWrite(PinD,HIGH);
  digitalWrite(PinE,HIGH);
  digitalWrite(PinG,HIGH);
  delay(2000);
  ClearLed();

  
  digitalWrite(PinD,HIGH);
  digitalWrite(PinE,HIGH);
  digitalWrite(PinF,HIGH);
  digitalWrite(PinG,HIGH);
  delay(2000);
  ClearLed();

  
}
