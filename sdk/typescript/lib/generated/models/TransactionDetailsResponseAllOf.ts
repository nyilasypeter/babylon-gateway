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
import type { TransactionDetails } from './TransactionDetails';
import {
    TransactionDetailsFromJSON,
    TransactionDetailsFromJSONTyped,
    TransactionDetailsToJSON,
} from './TransactionDetails';
import type { TransactionInfo } from './TransactionInfo';
import {
    TransactionInfoFromJSON,
    TransactionInfoFromJSONTyped,
    TransactionInfoToJSON,
} from './TransactionInfo';

/**
 * 
 * @export
 * @interface TransactionDetailsResponseAllOf
 */
export interface TransactionDetailsResponseAllOf {
    /**
     * 
     * @type {TransactionInfo}
     * @memberof TransactionDetailsResponseAllOf
     */
    transaction: TransactionInfo;
    /**
     * 
     * @type {TransactionDetails}
     * @memberof TransactionDetailsResponseAllOf
     */
    details: TransactionDetails;
}

/**
 * Check if a given object implements the TransactionDetailsResponseAllOf interface.
 */
export function instanceOfTransactionDetailsResponseAllOf(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "transaction" in value;
    isInstance = isInstance && "details" in value;

    return isInstance;
}

export function TransactionDetailsResponseAllOfFromJSON(json: any): TransactionDetailsResponseAllOf {
    return TransactionDetailsResponseAllOfFromJSONTyped(json, false);
}

export function TransactionDetailsResponseAllOfFromJSONTyped(json: any, ignoreDiscriminator: boolean): TransactionDetailsResponseAllOf {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'transaction': TransactionInfoFromJSON(json['transaction']),
        'details': TransactionDetailsFromJSON(json['details']),
    };
}

export function TransactionDetailsResponseAllOfToJSON(value?: TransactionDetailsResponseAllOf | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'transaction': TransactionInfoToJSON(value.transaction),
        'details': TransactionDetailsToJSON(value.details),
    };
}

