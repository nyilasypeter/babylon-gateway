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
/**
 * 
 * @export
 * @interface GatewayInfoResponseKnownTarget
 */
export interface GatewayInfoResponseKnownTarget {
    /**
     * The latest-seen state version of the tip of the network's ledger. If this is significantly ahead of the current ledger state version, the Network Gateway is possibly behind and may be reporting outdated information.
     * @type {number}
     * @memberof GatewayInfoResponseKnownTarget
     */
    state_version: number;
}

/**
 * Check if a given object implements the GatewayInfoResponseKnownTarget interface.
 */
export function instanceOfGatewayInfoResponseKnownTarget(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "state_version" in value;

    return isInstance;
}

export function GatewayInfoResponseKnownTargetFromJSON(json: any): GatewayInfoResponseKnownTarget {
    return GatewayInfoResponseKnownTargetFromJSONTyped(json, false);
}

export function GatewayInfoResponseKnownTargetFromJSONTyped(json: any, ignoreDiscriminator: boolean): GatewayInfoResponseKnownTarget {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'state_version': json['state_version'],
    };
}

export function GatewayInfoResponseKnownTargetToJSON(value?: GatewayInfoResponseKnownTarget | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'state_version': value.state_version,
    };
}

