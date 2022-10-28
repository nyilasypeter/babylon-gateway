/* tslint:disable */
/* eslint-disable */
/**
 * Radix Babylon Gateway API
 * See https://docs.radixdlt.com/main/apis/introduction.html 
 *
 * The version of the OpenAPI document: 2.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { exists, mapValues } from '../runtime';
/**
 * 
 * @export
 * @interface GatewayInfoResponseGatewayApiVersions
 */
export interface GatewayInfoResponseGatewayApiVersions {
    /**
     * The release that is currently deployed to the Gateway API.
     * @type {string}
     * @memberof GatewayInfoResponseGatewayApiVersions
     */
    version: string;
    /**
     * The open api schema version that was used to generate the API models.
     * @type {string}
     * @memberof GatewayInfoResponseGatewayApiVersions
     */
    open_api_schema_version: string;
}

/**
 * Check if a given object implements the GatewayInfoResponseGatewayApiVersions interface.
 */
export function instanceOfGatewayInfoResponseGatewayApiVersions(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "version" in value;
    isInstance = isInstance && "open_api_schema_version" in value;

    return isInstance;
}

export function GatewayInfoResponseGatewayApiVersionsFromJSON(json: any): GatewayInfoResponseGatewayApiVersions {
    return GatewayInfoResponseGatewayApiVersionsFromJSONTyped(json, false);
}

export function GatewayInfoResponseGatewayApiVersionsFromJSONTyped(json: any, ignoreDiscriminator: boolean): GatewayInfoResponseGatewayApiVersions {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'version': json['version'],
        'open_api_schema_version': json['open_api_schema_version'],
    };
}

export function GatewayInfoResponseGatewayApiVersionsToJSON(value?: GatewayInfoResponseGatewayApiVersions | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'version': value.version,
        'open_api_schema_version': value.open_api_schema_version,
    };
}

