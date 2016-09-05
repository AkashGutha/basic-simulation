namespace Basic.Gates
{
    public class Or : Node
    {
        public Or():base(2,1){

        }

        public void setInputs(byte i1 , byte i2){
            input[0] = i1;
            input[1] = i2;
        }

        public override void calculate(){
            output[0] =  (byte)(input[0] | input[1]);
        }
    }
}