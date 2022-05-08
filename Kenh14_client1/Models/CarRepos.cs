namespace Kenh14_client1.Models
{
    public class CarRepos
    {
        public List<Car>  getAllCar()
        {
            List<Car> cars = new List<Car>()
            {
                new Car(){ img = "tributo.jpg", Name = "R3800"},
                new Car(){ img = "tributo.jpg", Name = "R3800"},
                new Car(){ img = "tributo.jpg", Name = "R3800"},
                new Car(){ img = "812 GTS.jpg", Name = "R3800"},
                new Car(){ img = "ferrari.jpg", Name = "R3800"}
            };
            return cars;
        }
    }
}
