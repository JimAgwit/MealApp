import { Component } from '@angular/core';
import { Meal } from './models/meal';
import { MealService } from './services/meal.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'ClientApp';
  meals: Meal[] = [];
 

  constructor(private mealService : MealService){}


  getRandomMeal() {
    this.mealService.getRandomMeal().subscribe(
      (response) => {
      
        // Process the response data
        console.log(response); // You can do whatever you want with the data here
        this.meals = response.meals;
      },
      (error) => {
        // Handle any errors
        console.error(error);
      }
    );
  }
  
}