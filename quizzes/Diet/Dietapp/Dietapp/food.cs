namespace Dietapp
{
    public class food
    {
        public string FoodName;
        public double Price;
        public string Serving;
        public double ServingSize;
        public double Calories;
        public double Cholesterol;
        public double Total_Fat;
        public double Sodium;
        public double Carbohydrates;
        public double Dietary_Fiber;
        public double Protein;
        public double Vit_A;
        public double Vit_C;
        public double Calcium;
        public double Iron;

        public food(string FoodName,double Price,string Serving,double ServingSize,
          double Calories,double Cholesterol,double Total_Fat,
          double Sodium,double Carbohydrates,double Dietary_Fiber,
          double Protein,double Vit_A,double Vit_C,double Calcium,double Iron)
        {
            this.FoodName = FoodName;
            this.Price = Price;
            this.Serving = Serving;
            this.ServingSize = ServingSize;
            this.Calories = Calories;
            this.Cholesterol = Cholesterol;
            this.Total_Fat = Total_Fat;
            this.Sodium = Sodium;
            this.Carbohydrates = Carbohydrates;
            this.Dietary_Fiber = Dietary_Fiber;
            this.Protein = Protein;
            this.Vit_A = Vit_A;
            this.Vit_C = Vit_C;
            this.Calcium = Calcium;
            this.Iron = Iron;
        }
    }
}
