namespace Basic.Gates
{
    public class and : Node
    {
        public and(int n_in , int n_out):base(n_in,n_out){

        }

        public void setInputs(){
            input[0] = 1;
            input[1] = 1;
        }

        public override void calculate(){
            byte result = 0;
            for (int i = 0; i < input.Length; i++)
            {
                result &= input[i] ;
            }
            output[0] = result;
        }
    }
}