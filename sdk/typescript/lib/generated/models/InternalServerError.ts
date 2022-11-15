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
import type { GatewayError } from './GatewayError';
import {
    GatewayErrorFromJSON,
    GatewayErrorFromJSONTyped,
    GatewayErrorToJSON,
} from './GatewayError';

/**
 * 
 * @export
 * @interface InternalServerError
 */
export interface InternalServerError extends GatewayError {
    /**
     * Gives an error type which occurred within the Gateway API when serving the request.
     * @type {string}
     * @memberof InternalServerError
     */
    exception: string;
    /**
     * Gives a human readable message - likely just a trace ID for reporting the error.
     * @type {string}
     * @memberof InternalServerError
     */
    cause: string;
}

/**
 * Check if a given object implements the InternalServerError interface.
 */
export function instanceOfInternalServerError(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "exception" in value;
    isInstance = isInstance && "cause" in value;

    return isInstance;
}

export function InternalServerErrorFromJSON(json: any): InternalServerError {
    return InternalServerErrorFromJSONTyped(json, false);
}

export function InternalServerErrorFromJSONTyped(json: any, ignoreDiscriminator: boolean): InternalServerError {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        ...GatewayErrorFromJSONTyped(json, ignoreDiscriminator),
        'exception': json['exception'],
        'cause': json['cause'],
    };
}

export function InternalServerErrorToJSON(value?: InternalServerError | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        ...GatewayErrorToJSON(value),
        'exception': value.exception,
        'cause': value.cause,
    };
}
