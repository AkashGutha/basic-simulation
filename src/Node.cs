namespace Basic{
    public class Node
    {
        public string Name { get; set; }
        public byte[] input { get; set; }
        public byte[] output { get; set; }

        public Node(int num_of_inputs, int num_of_outputs)
        {
            input = new byte[num_of_inputs];
            output = new byte[num_of_outputs];
        }

        public void setName(string name){
            this.Name = name; 
        }

        public virtual void calculate(){

        }

    }
}