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
import type { GatewayInfoResponseGatewayApiVersions } from './GatewayInfoResponseGatewayApiVersions';
import {
    GatewayInfoResponseGatewayApiVersionsFromJSON,
    GatewayInfoResponseGatewayApiVersionsFromJSONTyped,
    GatewayInfoResponseGatewayApiVersionsToJSON,
} from './GatewayInfoResponseGatewayApiVersions';
import type { GatewayInfoResponseTargetLedgerState } from './GatewayInfoResponseTargetLedgerState';
import {
    GatewayInfoResponseTargetLedgerStateFromJSON,
    GatewayInfoResponseTargetLedgerStateFromJSONTyped,
    GatewayInfoResponseTargetLedgerStateToJSON,
} from './GatewayInfoResponseTargetLedgerState';
import type { LedgerState } from './LedgerState';
import {
    LedgerStateFromJSON,
    LedgerStateFromJSONTyped,
    LedgerStateToJSON,
} from './LedgerState';

/**
 * 
 * @export
 * @interface GatewayInfoResponse
 */
export interface GatewayInfoResponse {
    /**
     * 
     * @type {LedgerState}
     * @memberof GatewayInfoResponse
     */
    ledger_state: LedgerState;
    /**
     * 
     * @type {GatewayInfoResponseGatewayApiVersions}
     * @memberof GatewayInfoResponse
     */
    gateway_api: GatewayInfoResponseGatewayApiVersions;
    /**
     * 
     * @type {GatewayInfoResponseTargetLedgerState}
     * @memberof GatewayInfoResponse
     */
    target_ledger_state: GatewayInfoResponseTargetLedgerState;
}

/**
 * Check if a given object implements the GatewayInfoResponse interface.
 */
export function instanceOfGatewayInfoResponse(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "ledger_state" in value;
    isInstance = isInstance && "gateway_api" in value;
    isInstance = isInstance && "target_ledger_state" in value;

    return isInstance;
}

export function GatewayInfoResponseFromJSON(json: any): GatewayInfoResponse {
    return GatewayInfoResponseFromJSONTyped(json, false);
}

export function GatewayInfoResponseFromJSONTyped(json: any, ignoreDiscriminator: boolean): GatewayInfoResponse {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'ledger_state': LedgerStateFromJSON(json['ledger_state']),
        'gateway_api': GatewayInfoResponseGatewayApiVersionsFromJSON(json['gateway_api']),
        'target_ledger_state': GatewayInfoResponseTargetLedgerStateFromJSON(json['target_ledger_state']),
    };
}

export function GatewayInfoResponseToJSON(value?: GatewayInfoResponse | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'ledger_state': LedgerStateToJSON(value.ledger_state),
        'gateway_api': GatewayInfoResponseGatewayApiVersionsToJSON(value.gateway_api),
        'target_ledger_state': GatewayInfoResponseTargetLedgerStateToJSON(value.target_ledger_state),
    };
}

