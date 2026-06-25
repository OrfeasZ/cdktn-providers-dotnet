using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsNamespaceAssociation
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.logAnalyticsNamespaceAssociation.LogAnalyticsNamespaceAssociationAssociationProperties")]
    public class LogAnalyticsNamespaceAssociationAssociationProperties : oci.LogAnalyticsNamespaceAssociation.ILogAnalyticsNamespaceAssociationAssociationProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/log_analytics_namespace_association#name LogAnalyticsNamespaceAssociation#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        private object? _patterns;

        /// <summary>patterns block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/log_analytics_namespace_association#patterns LogAnalyticsNamespaceAssociation#patterns}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.LogAnalyticsNamespaceAssociation.ILogAnalyticsNamespaceAssociationAssociationPropertiesPatterns" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "patterns", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.logAnalyticsNamespaceAssociation.LogAnalyticsNamespaceAssociationAssociationPropertiesPatterns\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Patterns
        {
            get => _patterns;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.LogAnalyticsNamespaceAssociation.ILogAnalyticsNamespaceAssociationAssociationPropertiesPatterns[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.LogAnalyticsNamespaceAssociation.ILogAnalyticsNamespaceAssociationAssociationPropertiesPatterns).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _patterns = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/log_analytics_namespace_association#value LogAnalyticsNamespaceAssociation#value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Value
        {
            get;
            set;
        }
    }
}
