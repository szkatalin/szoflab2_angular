import { Component, OnInit } from '@angular/core';
import {Advertisement, Filter} from '../models';
import {HttpClient, HttpParams} from '@angular/common/http';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.css']
})
export class ListComponent implements OnInit {
  filter: Filter = new Filter();
  advertisements: Advertisement[];

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getAdvertisements();
  }

  getAdvertisements() {
    this.http.get<Advertisement[]>('/api/advertisements',
      { params: new HttpParams({ fromObject: this.filter as any }) })
      .subscribe(resp => this.advertisements = resp);
  }
}

