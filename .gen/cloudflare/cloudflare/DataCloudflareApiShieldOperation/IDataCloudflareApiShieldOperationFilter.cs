using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareApiShieldOperation
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareApiShieldOperationFilter), fullyQualifiedName: "cloudflare.dataCloudflareApiShieldOperation.DataCloudflareApiShieldOperationFilter")]
    public interface IDataCloudflareApiShieldOperationFilter
    {
        /// <summary>Direction to order results. Available values: "asc", "desc".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/api_shield_operation#direction DataCloudflareApiShieldOperation#direction}
        /// </remarks>
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Direction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Filter results to only include endpoints containing this pattern.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/api_shield_operation#endpoint DataCloudflareApiShieldOperation#endpoint}
        /// </remarks>
        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Endpoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>Add feature(s) to the results.</summary>
        /// <remarks>
        /// The feature name that is given here corresponds to the resulting feature object. Have a look at the top-level object description for more details on the specific meaning.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/api_shield_operation#feature DataCloudflareApiShieldOperation#feature}
        /// </remarks>
        [JsiiProperty(name: "feature", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Feature
        {
            get
            {
                return null;
            }
        }

        /// <summary>Filter results to only include the specified hosts.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/api_shield_operation#host DataCloudflareApiShieldOperation#host}
        /// </remarks>
        [JsiiProperty(name: "host", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Host
        {
            get
            {
                return null;
            }
        }

        /// <summary>Filter results to only include the specified HTTP methods.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/api_shield_operation#method DataCloudflareApiShieldOperation#method}
        /// </remarks>
        [JsiiProperty(name: "method", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Method
        {
            get
            {
                return null;
            }
        }

        /// <summary>Field to order by.</summary>
        /// <remarks>
        /// When requesting a feature, the feature keys are available for ordering as well, e.g., <c>thresholds.suggested_threshold</c>.
        /// Available values: "method", "host", "endpoint", "thresholds.$key".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/api_shield_operation#order DataCloudflareApiShieldOperation#order}
        /// </remarks>
        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Order
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareApiShieldOperationFilter), fullyQualifiedName: "cloudflare.dataCloudflareApiShieldOperation.DataCloudflareApiShieldOperationFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareApiShieldOperation.IDataCloudflareApiShieldOperationFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Direction to order results. Available values: "asc", "desc".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/api_shield_operation#direction DataCloudflareApiShieldOperation#direction}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Direction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Filter results to only include endpoints containing this pattern.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/api_shield_operation#endpoint DataCloudflareApiShieldOperation#endpoint}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Endpoint
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Add feature(s) to the results.</summary>
            /// <remarks>
            /// The feature name that is given here corresponds to the resulting feature object. Have a look at the top-level object description for more details on the specific meaning.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/api_shield_operation#feature DataCloudflareApiShieldOperation#feature}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "feature", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Feature
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Filter results to only include the specified hosts.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/api_shield_operation#host DataCloudflareApiShieldOperation#host}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "host", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Host
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Filter results to only include the specified HTTP methods.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/api_shield_operation#method DataCloudflareApiShieldOperation#method}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "method", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Method
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Field to order by.</summary>
            /// <remarks>
            /// When requesting a feature, the feature keys are available for ordering as well, e.g., <c>thresholds.suggested_threshold</c>.
            /// Available values: "method", "host", "endpoint", "thresholds.$key".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/api_shield_operation#order DataCloudflareApiShieldOperation#order}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Order
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
