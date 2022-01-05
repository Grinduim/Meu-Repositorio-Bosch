int PinA = 9;
int PinB = 2;
int PinC = 3;
int PinD = 4;
int PinE = 5;
int PinF = 6;
int PinG = 7;
int PinP = 8;

int Led1 = 11;

int Button = 13;

char nome[] = "vinicius";

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

  pinMode(Led1, OUTPUT);

  pinMode(Button,INPUT);
  
  Serial.begin(9600);
}

void ClearLed(){ // função para limpar o visor
  int i = 0;
  for(i = 2; i<=9; i++){
      digitalWrite(i,LOW);
  }
}

void loop() {
  // ao apertar um botão deve aparecer L no visor e o led deve acender  se n~~ao estiver aparecer D
  int press = digitalRead(Button);
  digitalWrite(Led1,LOW);
  ClearLed();
  if(press == LOW){
    digitalWrite(PinF,HIGH);
    digitalWrite(PinD,HIGH);
    digitalWrite(PinE,HIGH);

    digitalWrite(Led1,HIGH);
    
  }
  else{
    digitalWrite(PinB,HIGH);
    digitalWrite(PinC,HIGH);
    digitalWrite(PinE,HIGH);
    digitalWrite(PinD,HIGH);
    digitalWrite(PinG,HIGH);
  }





  
  
}
