using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareShare
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareShareFilter), fullyQualifiedName: "cloudflare.dataCloudflareShare.DataCloudflareShareFilter")]
    public interface IDataCloudflareShareFilter
    {
        /// <summary>Direction to sort objects. Available values: "asc", "desc".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/data-sources/share#direction DataCloudflareShare#direction}
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

        /// <summary>Filter shares by kind. Available values: "sent", "received".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/data-sources/share#kind DataCloudflareShare#kind}
        /// </remarks>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Kind
        {
            get
            {
                return null;
            }
        }

        /// <summary>Order shares by values in the given field. Available values: "name", "created".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/data-sources/share#order DataCloudflareShare#order}
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

        /// <summary>Filter share resources by resource_types.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/data-sources/share#resource_types DataCloudflareShare#resource_types}
        /// </remarks>
        [JsiiProperty(name: "resourceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ResourceTypes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Filter shares by status. Available values: "active", "deleting", "deleted".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/data-sources/share#status DataCloudflareShare#status}
        /// </remarks>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Status
        {
            get
            {
                return null;
            }
        }

        /// <summary>Filter shares by tag.</summary>
        /// <remarks>
        /// Each value is either <c>key=value</c> (matches shares whose tags contain that key/value pair) or <c>key</c> alone (matches shares that have any value for that key). May be repeated; multiple <c>tag</c> parameters are ANDed together. Maximum 20 <c>tag</c> parameters per request.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/data-sources/share#tag DataCloudflareShare#tag}
        /// </remarks>
        [JsiiProperty(name: "tag", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Tag
        {
            get
            {
                return null;
            }
        }

        /// <summary>Filter shares by target_type. Available values: "account", "organization".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/data-sources/share#target_type DataCloudflareShare#target_type}
        /// </remarks>
        [JsiiProperty(name: "targetType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareShareFilter), fullyQualifiedName: "cloudflare.dataCloudflareShare.DataCloudflareShareFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareShare.IDataCloudflareShareFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Direction to sort objects. Available values: "asc", "desc".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/data-sources/share#direction DataCloudflareShare#direction}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Direction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Filter shares by kind. Available values: "sent", "received".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/data-sources/share#kind DataCloudflareShare#kind}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Kind
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Order shares by values in the given field. Available values: "name", "created".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/data-sources/share#order DataCloudflareShare#order}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Order
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Filter share resources by resource_types.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/data-sources/share#resource_types DataCloudflareShare#resource_types}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ResourceTypes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Filter shares by status. Available values: "active", "deleting", "deleted".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/data-sources/share#status DataCloudflareShare#status}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Status
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Filter shares by tag.</summary>
            /// <remarks>
            /// Each value is either <c>key=value</c> (matches shares whose tags contain that key/value pair) or <c>key</c> alone (matches shares that have any value for that key). May be repeated; multiple <c>tag</c> parameters are ANDed together. Maximum 20 <c>tag</c> parameters per request.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/data-sources/share#tag DataCloudflareShare#tag}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tag", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Tag
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Filter shares by target_type. Available values: "account", "organization".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/data-sources/share#target_type DataCloudflareShare#target_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "targetType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
