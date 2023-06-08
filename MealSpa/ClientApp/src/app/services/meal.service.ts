import { Injectable } from '@angular/core';
import { Meal } from '../models/meal';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment.development';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root',
})
export class MealService {
  private url = 'mealUrl';

  constructor(private http: HttpClient) {}

  public getRandomMeal(): Observable<any> {
    const apiUrl = environment.apiUrl;
    return this.http.get(apiUrl);
  }
}
