namespace Statisch
{
    class Lift
    {
        private int _currentFloor = 0;

        public int CurrentFloor { 
            get {  return _currentFloor; } 
        }
        public void Call(int floor)
        {
            Console.WriteLine($"Lift zoeft naar de {floor}e verdieping");
            _currentFloor = floor;
        }
    }
}