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
 * @interface TokenIdentifier
 */
export interface TokenIdentifier {
    /**
     * The radix resource identifier of the token.
     * @type {string}
     * @memberof TokenIdentifier
     */
    rri: string;
}

/**
 * Check if a given object implements the TokenIdentifier interface.
 */
export function instanceOfTokenIdentifier(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "rri" in value;

    return isInstance;
}

export function TokenIdentifierFromJSON(json: any): TokenIdentifier {
    return TokenIdentifierFromJSONTyped(json, false);
}

export function TokenIdentifierFromJSONTyped(json: any, ignoreDiscriminator: boolean): TokenIdentifier {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'rri': json['rri'],
    };
}

export function TokenIdentifierToJSON(value?: TokenIdentifier | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'rri': value.rri,
    };
}

