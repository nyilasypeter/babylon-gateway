/* tslint:disable */
/* eslint-disable */
/**
 * Babylon Gateway API - RCnet V1
 * This API is exposed by the Babylon Radix Gateway to enable clients to efficiently query current and historic state on the RadixDLT ledger, and intelligently handle transaction submission.  It is designed for use by wallets and explorers. For simple use cases, you can typically use the Core API on a Node. A Gateway is only needed for reading historic snapshots of ledger states or a more robust set-up.  The Gateway API is implemented by the [Network Gateway](https://github.com/radixdlt/babylon-gateway), which is configured to read from [full node(s)](https://github.com/radixdlt/babylon-node) to extract and index data from the network.  This document is an API reference documentation, visit [User Guide](https://docs-babylon.radixdlt.com/) to learn more about how to run a Gateway of your own.  ## Integration and forward compatibility guarantees  We give no guarantees that other endpoints will not change before Babylon mainnet launch, although changes are expected to be minimal. 
 *
 * The version of the OpenAPI document: 0.3.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { exists, mapValues } from '../runtime';
import type { GatewayInfoResponseReleaseInfo } from './GatewayInfoResponseReleaseInfo';
import {
    GatewayInfoResponseReleaseInfoFromJSON,
    GatewayInfoResponseReleaseInfoFromJSONTyped,
    GatewayInfoResponseReleaseInfoToJSON,
} from './GatewayInfoResponseReleaseInfo';
import type { LedgerState } from './LedgerState';
import {
    LedgerStateFromJSON,
    LedgerStateFromJSONTyped,
    LedgerStateToJSON,
} from './LedgerState';

/**
 * 
 * @export
 * @interface GatewayStatusResponse
 */
export interface GatewayStatusResponse {
    /**
     * 
     * @type {LedgerState}
     * @memberof GatewayStatusResponse
     */
    ledger_state: LedgerState;
    /**
     * 
     * @type {GatewayInfoResponseReleaseInfo}
     * @memberof GatewayStatusResponse
     */
    release_info: GatewayInfoResponseReleaseInfo;
}

/**
 * Check if a given object implements the GatewayStatusResponse interface.
 */
export function instanceOfGatewayStatusResponse(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "ledger_state" in value;
    isInstance = isInstance && "release_info" in value;

    return isInstance;
}

export function GatewayStatusResponseFromJSON(json: any): GatewayStatusResponse {
    return GatewayStatusResponseFromJSONTyped(json, false);
}

export function GatewayStatusResponseFromJSONTyped(json: any, ignoreDiscriminator: boolean): GatewayStatusResponse {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'ledger_state': LedgerStateFromJSON(json['ledger_state']),
        'release_info': GatewayInfoResponseReleaseInfoFromJSON(json['release_info']),
    };
}

export function GatewayStatusResponseToJSON(value?: GatewayStatusResponse | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'ledger_state': LedgerStateToJSON(value.ledger_state),
        'release_info': GatewayInfoResponseReleaseInfoToJSON(value.release_info),
    };
}

