using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsNamespaceAssociation
{
    [JsiiInterface(nativeType: typeof(ILogAnalyticsNamespaceAssociationAssociationProperties), fullyQualifiedName: "oci.logAnalyticsNamespaceAssociation.LogAnalyticsNamespaceAssociationAssociationProperties")]
    public interface ILogAnalyticsNamespaceAssociationAssociationProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/log_analytics_namespace_association#name LogAnalyticsNamespaceAssociation#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>patterns block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/log_analytics_namespace_association#patterns LogAnalyticsNamespaceAssociation#patterns}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.LogAnalyticsNamespaceAssociation.ILogAnalyticsNamespaceAssociationAssociationPropertiesPatterns" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "patterns", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.logAnalyticsNamespaceAssociation.LogAnalyticsNamespaceAssociationAssociationPropertiesPatterns\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Patterns
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/log_analytics_namespace_association#value LogAnalyticsNamespaceAssociation#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Value
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILogAnalyticsNamespaceAssociationAssociationProperties), fullyQualifiedName: "oci.logAnalyticsNamespaceAssociation.LogAnalyticsNamespaceAssociationAssociationProperties")]
        internal sealed class _Proxy : DeputyBase, oci.LogAnalyticsNamespaceAssociation.ILogAnalyticsNamespaceAssociationAssociationProperties
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/log_analytics_namespace_association#name LogAnalyticsNamespaceAssociation#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>patterns block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/log_analytics_namespace_association#patterns LogAnalyticsNamespaceAssociation#patterns}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.LogAnalyticsNamespaceAssociation.ILogAnalyticsNamespaceAssociationAssociationPropertiesPatterns" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "patterns", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.logAnalyticsNamespaceAssociation.LogAnalyticsNamespaceAssociationAssociationPropertiesPatterns\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Patterns
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/log_analytics_namespace_association#value LogAnalyticsNamespaceAssociation#value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Value
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
