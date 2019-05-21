
#include<IRremote.h>

//Define senso pin
const int RECV_PIN = 4;

//Define IR Receiver and Results Objects
IRrecv irrecv(RECV_PIN);
decode_results results;

void setup()
{
  // put your setup code here, to run once:
  Serial.begin(9600);
  //Enable the IR Reciever
  irrecv.enableIRIn();

}

void loop() 
{
  // put your main code here, to run repeatedly:
  if(irrecv.decode(&results))
  {
    //Print Code in HEX
    Serial.println(results.value, HEX);
    irrecv.resume();
  }
}
