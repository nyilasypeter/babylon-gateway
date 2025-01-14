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


import * as runtime from '../runtime';
import type {
  ErrorResponse,
  TransactionCommittedDetailsRequest,
  TransactionCommittedDetailsResponse,
  TransactionConstructionResponse,
  TransactionPreviewRequest,
  TransactionPreviewResponse,
  TransactionStatusRequest,
  TransactionStatusResponse,
  TransactionSubmitRequest,
  TransactionSubmitResponse,
} from '../models';
import {
    ErrorResponseFromJSON,
    ErrorResponseToJSON,
    TransactionCommittedDetailsRequestFromJSON,
    TransactionCommittedDetailsRequestToJSON,
    TransactionCommittedDetailsResponseFromJSON,
    TransactionCommittedDetailsResponseToJSON,
    TransactionConstructionResponseFromJSON,
    TransactionConstructionResponseToJSON,
    TransactionPreviewRequestFromJSON,
    TransactionPreviewRequestToJSON,
    TransactionPreviewResponseFromJSON,
    TransactionPreviewResponseToJSON,
    TransactionStatusRequestFromJSON,
    TransactionStatusRequestToJSON,
    TransactionStatusResponseFromJSON,
    TransactionStatusResponseToJSON,
    TransactionSubmitRequestFromJSON,
    TransactionSubmitRequestToJSON,
    TransactionSubmitResponseFromJSON,
    TransactionSubmitResponseToJSON,
} from '../models';

export interface TransactionCommittedDetailsOperationRequest {
    transactionCommittedDetailsRequest: TransactionCommittedDetailsRequest;
}

export interface TransactionPreviewOperationRequest {
    transactionPreviewRequest: TransactionPreviewRequest;
}

export interface TransactionStatusOperationRequest {
    transactionStatusRequest: TransactionStatusRequest;
}

export interface TransactionSubmitOperationRequest {
    transactionSubmitRequest: TransactionSubmitRequest;
}

/**
 * 
 */
export class TransactionApi extends runtime.BaseAPI {

    /**
     * Returns the committed details and receipt of the transaction for a given transaction identifier. Transaction identifiers which don\'t correspond to a committed transaction will return a `TransactionNotFoundError`. 
     * Get Committed Transaction Details
     */
    async transactionCommittedDetailsRaw(requestParameters: TransactionCommittedDetailsOperationRequest, initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<runtime.ApiResponse<TransactionCommittedDetailsResponse>> {
        if (requestParameters.transactionCommittedDetailsRequest === null || requestParameters.transactionCommittedDetailsRequest === undefined) {
            throw new runtime.RequiredError('transactionCommittedDetailsRequest','Required parameter requestParameters.transactionCommittedDetailsRequest was null or undefined when calling transactionCommittedDetails.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        const response = await this.request({
            path: `/transaction/committed-details`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: TransactionCommittedDetailsRequestToJSON(requestParameters.transactionCommittedDetailsRequest),
        }, initOverrides);

        return new runtime.JSONApiResponse(response, (jsonValue) => TransactionCommittedDetailsResponseFromJSON(jsonValue));
    }

    /**
     * Returns the committed details and receipt of the transaction for a given transaction identifier. Transaction identifiers which don\'t correspond to a committed transaction will return a `TransactionNotFoundError`. 
     * Get Committed Transaction Details
     */
    async transactionCommittedDetails(requestParameters: TransactionCommittedDetailsOperationRequest, initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<TransactionCommittedDetailsResponse> {
        const response = await this.transactionCommittedDetailsRaw(requestParameters, initOverrides);
        return await response.value();
    }

    /**
     * Returns information needed to construct a new transaction including current `epoch` number. 
     * Get Construction Metadata
     */
    async transactionConstructionRaw(initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<runtime.ApiResponse<TransactionConstructionResponse>> {
        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        const response = await this.request({
            path: `/transaction/construction`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
        }, initOverrides);

        return new runtime.JSONApiResponse(response, (jsonValue) => TransactionConstructionResponseFromJSON(jsonValue));
    }

    /**
     * Returns information needed to construct a new transaction including current `epoch` number. 
     * Get Construction Metadata
     */
    async transactionConstruction(initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<TransactionConstructionResponse> {
        const response = await this.transactionConstructionRaw(initOverrides);
        return await response.value();
    }

    /**
     * Previews transaction against the network. This endpoint is effectively a proxy towards CoreApi\'s `/v0/transaction/preview` endpoint. See CoreApi\'s documentation for more details. 
     * Preview Transaction
     */
    async transactionPreviewRaw(requestParameters: TransactionPreviewOperationRequest, initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<runtime.ApiResponse<TransactionPreviewResponse>> {
        if (requestParameters.transactionPreviewRequest === null || requestParameters.transactionPreviewRequest === undefined) {
            throw new runtime.RequiredError('transactionPreviewRequest','Required parameter requestParameters.transactionPreviewRequest was null or undefined when calling transactionPreview.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        const response = await this.request({
            path: `/transaction/preview`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: TransactionPreviewRequestToJSON(requestParameters.transactionPreviewRequest),
        }, initOverrides);

        return new runtime.JSONApiResponse(response, (jsonValue) => TransactionPreviewResponseFromJSON(jsonValue));
    }

    /**
     * Previews transaction against the network. This endpoint is effectively a proxy towards CoreApi\'s `/v0/transaction/preview` endpoint. See CoreApi\'s documentation for more details. 
     * Preview Transaction
     */
    async transactionPreview(requestParameters: TransactionPreviewOperationRequest, initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<TransactionPreviewResponse> {
        const response = await this.transactionPreviewRaw(requestParameters, initOverrides);
        return await response.value();
    }

    /**
     * Returns overall transaction status and all of its known payloads based on supplied intent hash. 
     * Get Transaction Status
     */
    async transactionStatusRaw(requestParameters: TransactionStatusOperationRequest, initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<runtime.ApiResponse<TransactionStatusResponse>> {
        if (requestParameters.transactionStatusRequest === null || requestParameters.transactionStatusRequest === undefined) {
            throw new runtime.RequiredError('transactionStatusRequest','Required parameter requestParameters.transactionStatusRequest was null or undefined when calling transactionStatus.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        const response = await this.request({
            path: `/transaction/status`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: TransactionStatusRequestToJSON(requestParameters.transactionStatusRequest),
        }, initOverrides);

        return new runtime.JSONApiResponse(response, (jsonValue) => TransactionStatusResponseFromJSON(jsonValue));
    }

    /**
     * Returns overall transaction status and all of its known payloads based on supplied intent hash. 
     * Get Transaction Status
     */
    async transactionStatus(requestParameters: TransactionStatusOperationRequest, initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<TransactionStatusResponse> {
        const response = await this.transactionStatusRaw(requestParameters, initOverrides);
        return await response.value();
    }

    /**
     * Submits a signed transaction payload to the network. 
     * Submit Transaction
     */
    async transactionSubmitRaw(requestParameters: TransactionSubmitOperationRequest, initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<runtime.ApiResponse<TransactionSubmitResponse>> {
        if (requestParameters.transactionSubmitRequest === null || requestParameters.transactionSubmitRequest === undefined) {
            throw new runtime.RequiredError('transactionSubmitRequest','Required parameter requestParameters.transactionSubmitRequest was null or undefined when calling transactionSubmit.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        headerParameters['Content-Type'] = 'application/json';

        const response = await this.request({
            path: `/transaction/submit`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: TransactionSubmitRequestToJSON(requestParameters.transactionSubmitRequest),
        }, initOverrides);

        return new runtime.JSONApiResponse(response, (jsonValue) => TransactionSubmitResponseFromJSON(jsonValue));
    }

    /**
     * Submits a signed transaction payload to the network. 
     * Submit Transaction
     */
    async transactionSubmit(requestParameters: TransactionSubmitOperationRequest, initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<TransactionSubmitResponse> {
        const response = await this.transactionSubmitRaw(requestParameters, initOverrides);
        return await response.value();
    }

}
