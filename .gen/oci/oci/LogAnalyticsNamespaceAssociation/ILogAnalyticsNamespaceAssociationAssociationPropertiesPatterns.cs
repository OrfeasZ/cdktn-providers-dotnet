using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsNamespaceAssociation
{
    [JsiiInterface(nativeType: typeof(ILogAnalyticsNamespaceAssociationAssociationPropertiesPatterns), fullyQualifiedName: "oci.logAnalyticsNamespaceAssociation.LogAnalyticsNamespaceAssociationAssociationPropertiesPatterns")]
    public interface ILogAnalyticsNamespaceAssociationAssociationPropertiesPatterns
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/log_analytics_namespace_association#id LogAnalyticsNamespaceAssociation#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        string Id
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/log_analytics_namespace_association#value LogAnalyticsNamespaceAssociation#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILogAnalyticsNamespaceAssociationAssociationPropertiesPatterns), fullyQualifiedName: "oci.logAnalyticsNamespaceAssociation.LogAnalyticsNamespaceAssociationAssociationPropertiesPatterns")]
        internal sealed class _Proxy : DeputyBase, oci.LogAnalyticsNamespaceAssociation.ILogAnalyticsNamespaceAssociationAssociationPropertiesPatterns
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/log_analytics_namespace_association#id LogAnalyticsNamespaceAssociation#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
            public string Id
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/log_analytics_namespace_association#value LogAnalyticsNamespaceAssociation#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
