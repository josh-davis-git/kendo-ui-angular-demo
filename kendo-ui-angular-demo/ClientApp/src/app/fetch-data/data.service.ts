import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {
    toDataSourceRequestString,
    translateDataSourceResultGroups,
    translateAggregateResults,
    DataResult,
    DataSourceRequestState
} from '@progress/kendo-data-query';

import { GridDataResult, DataStateChangeEvent } from '@progress/kendo-angular-grid';

import { Observable } from 'rxjs';
import 'rxjs-compat';
import { map } from 'rxjs/operators';

@Injectable()
export class DataService {
  private BASE_URL: string = 'api/Products';

  constructor(private http: HttpClient) { }

  public fetch(state: DataSourceRequestState): Observable<DataResult> {
    const queryStr = `${toDataSourceRequestString(state)}`; //serialize the state
    const hasGroups = state.group && state.group.length;

    return this.http
      .get(`${this.BASE_URL}?${queryStr}`) //send the state to the server         
      .pipe(map(({ data, total/*, aggregateResults*/ }: GridDataResult) => // process the response
      (<GridDataResult>{
        //if there are groups convert them to compatible format
        data: hasGroups ? translateDataSourceResultGroups(data) : data,
        total: total,
        // convert the aggregates if such exists
        //aggregateResult: translateAggregateResults(aggregateResults)
      })
      )
  )}
}

