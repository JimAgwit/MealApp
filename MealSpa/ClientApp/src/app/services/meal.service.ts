import { Injectable } from '@angular/core';
import { Meal } from '../models/meal';

@Injectable({
  providedIn: 'root'
})
export class MealService {

  constructor() { }

  public getMeals() : Meal[]{
    let mealOne = new Meal;
    mealOne.IdMeal = 123;
    mealOne.StrMeal = "Pork Adobo";

    return [mealOne];

  }
}
