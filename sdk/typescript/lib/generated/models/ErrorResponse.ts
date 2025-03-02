/* tslint:disable */
/* eslint-disable */
/**
 * Babylon Gateway API - RCnet V2
 * This API is exposed by the Babylon Radix Gateway to enable clients to efficiently query current and historic state on the RadixDLT ledger, and intelligently handle transaction submission.  It is designed for use by wallets and explorers. For simple use cases, you can typically use the Core API on a Node. A Gateway is only needed for reading historic snapshots of ledger states or a more robust set-up.  The Gateway API is implemented by the [Network Gateway](https://github.com/radixdlt/babylon-gateway), which is configured to read from [full node(s)](https://github.com/radixdlt/babylon-node) to extract and index data from the network.  This document is an API reference documentation, visit [User Guide](https://docs-babylon.radixdlt.com/) to learn more about how to run a Gateway of your own.  ## Integration and forward compatibility guarantees  We give no guarantees that other endpoints will not change before Babylon mainnet launch, although changes are expected to be minimal. 
 *
 * The version of the OpenAPI document: 0.4.0
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
 * @interface ErrorResponse
 */
export interface ErrorResponse {
    /**
     * A human-readable error message.
     * @type {string}
     * @memberof ErrorResponse
     */
    message: string;
    /**
     * A numeric code corresponding to the given error type.
     * @type {number}
     * @memberof ErrorResponse
     */
    code?: number;
    /**
     * 
     * @type {GatewayError}
     * @memberof ErrorResponse
     */
    details?: GatewayError;
    /**
     * A unique request identifier to be used when reporting errors, to allow correlation with the Gateway API's error logs.
     * @type {string}
     * @memberof ErrorResponse
     */
    trace_id?: string;
}

/**
 * Check if a given object implements the ErrorResponse interface.
 */
export function instanceOfErrorResponse(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "message" in value;

    return isInstance;
}

export function ErrorResponseFromJSON(json: any): ErrorResponse {
    return ErrorResponseFromJSONTyped(json, false);
}

export function ErrorResponseFromJSONTyped(json: any, ignoreDiscriminator: boolean): ErrorResponse {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'message': json['message'],
        'code': !exists(json, 'code') ? undefined : json['code'],
        'details': !exists(json, 'details') ? undefined : GatewayErrorFromJSON(json['details']),
        'trace_id': !exists(json, 'trace_id') ? undefined : json['trace_id'],
    };
}

export function ErrorResponseToJSON(value?: ErrorResponse | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'message': value.message,
        'code': value.code,
        'details': GatewayErrorToJSON(value.details),
        'trace_id': value.trace_id,
    };
}

