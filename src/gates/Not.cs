namespace Basic.Gates
{
    public class Not : Node
    {
        public Not():base(1,1){

        }

        public void setInputs(byte i1){
            input[0] = i1;
        }

        public override void calculate(){
            output[0] = (byte) ~input[0];
        }
    }
}