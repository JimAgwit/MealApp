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

  ngOnInit() : void{
    this.meals = this.mealService.getMeals();
    console.log(this.meals);
  }

}
