namespace tpmodul4_1302220105
{
    internal class DoorMachine
    {
        private enum State
        {
            Terkunci,
            Terbuka
        }

        private State _state;

        public DoorMachine()
        {
            _state = State.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }

        public void ChangeState()
        {
            if (_state == State.Terkunci)
            {
                _state = State.Terbuka;
                Console.WriteLine("Pintu tidak terkunci");
            }
            else
            {
                _state = State.Terkunci;
                Console.WriteLine("Pintu terkunci");
            }
        }
    }
}
