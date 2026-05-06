using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudGuardAdhocQuery
{
    [JsiiInterface(nativeType: typeof(ICloudGuardAdhocQueryAdhocQueryDetails), fullyQualifiedName: "oci.cloudGuardAdhocQuery.CloudGuardAdhocQueryAdhocQueryDetails")]
    public interface ICloudGuardAdhocQueryAdhocQueryDetails
    {
        /// <summary>adhoc_query_resources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_adhoc_query#adhoc_query_resources CloudGuardAdhocQuery#adhoc_query_resources}
        /// </remarks>
        [JsiiProperty(name: "adhocQueryResources", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudGuardAdhocQuery.CloudGuardAdhocQueryAdhocQueryDetailsAdhocQueryResources\"},\"kind\":\"array\"}}]}}")]
        object AdhocQueryResources
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_adhoc_query#query CloudGuardAdhocQuery#query}.</summary>
        [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}")]
        string Query
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudGuardAdhocQueryAdhocQueryDetails), fullyQualifiedName: "oci.cloudGuardAdhocQuery.CloudGuardAdhocQueryAdhocQueryDetails")]
        internal sealed class _Proxy : DeputyBase, oci.CloudGuardAdhocQuery.ICloudGuardAdhocQueryAdhocQueryDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>adhoc_query_resources block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_adhoc_query#adhoc_query_resources CloudGuardAdhocQuery#adhoc_query_resources}
            /// </remarks>
            [JsiiProperty(name: "adhocQueryResources", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudGuardAdhocQuery.CloudGuardAdhocQueryAdhocQueryDetailsAdhocQueryResources\"},\"kind\":\"array\"}}]}}")]
            public object AdhocQueryResources
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_adhoc_query#query CloudGuardAdhocQuery#query}.</summary>
            [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}")]
            public string Query
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
