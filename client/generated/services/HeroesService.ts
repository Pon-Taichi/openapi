/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import type { Observable } from 'rxjs';

import type { CreateHeroCommand } from '../models/CreateHeroCommand';
import type { Hero } from '../models/Hero';
import type { Heroes } from '../models/Heroes';

import { OpenAPI } from '../core/OpenAPI';
import { request as __request } from '../core/request';

@Injectable({
    providedIn: 'root',
})
export class HeroesService {

    constructor(public readonly http: HttpClient) {}

    /**
     * ヒーロー一覧の取得
     * @returns Heroes ヒーロー一覧
     * @throws ApiError
     */
    public getHeroList(): Observable<Heroes> {
        return __request(OpenAPI, this.http, {
            method: 'GET',
            url: '/heroes',
        });
    }

    /**
     * ヒーローの新規作成
     * @param requestBody ヒーロー情報
     * @returns Hero 新規ヒーロー
     * @throws ApiError
     */
    public createHero(
        requestBody: CreateHeroCommand,
    ): Observable<Hero> {
        return __request(OpenAPI, this.http, {
            method: 'POST',
            url: '/heroes',
            body: requestBody,
            mediaType: 'application/json',
            errors: {
                400: `Client side error`,
            },
        });
    }

    /**
     * ヒーローの取得
     * @param heroId
     * @returns Hero OK
     * @throws ApiError
     */
    public getHero(
        heroId: string,
    ): Observable<Hero> {
        return __request(OpenAPI, this.http, {
            method: 'GET',
            url: '/heroes/{heroId}',
            path: {
                'heroId': heroId,
            },
        });
    }

    /**
     * ヒーローの更新
     * @param heroId
     * @returns Hero Updated
     * @throws ApiError
     */
    public updateHero(
        heroId: string,
    ): Observable<Hero> {
        return __request(OpenAPI, this.http, {
            method: 'PUT',
            url: '/heroes/{heroId}',
            path: {
                'heroId': heroId,
            },
        });
    }

    /**
     * ヒーローの削除
     * @param heroId
     * @returns void
     * @throws ApiError
     */
    public deleteHero(
        heroId: string,
    ): Observable<void> {
        return __request(OpenAPI, this.http, {
            method: 'DELETE',
            url: '/heroes/{heroId}',
            path: {
                'heroId': heroId,
            },
        });
    }

}
