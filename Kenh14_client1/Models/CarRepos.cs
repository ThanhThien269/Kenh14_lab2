namespace Kenh14_client1.Models
{
    public class CarRepos
    {
        public List<Car>  getAllCar()
        {
            List<Car> cars = new List<Car>()
            {
                new Car(){ img = "ferrari.jpg", Name = "R3800"},
                new Car(){ img = "ferrari.jpg", Name = "R3800"}
            };
            return cars;
        }
    }
}
