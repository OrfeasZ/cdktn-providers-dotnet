using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeTargetDatabaseGroup
{
    [JsiiByValue(fqn: "oci.dataSafeTargetDatabaseGroup.DataSafeTargetDatabaseGroupMatchingCriteriaInclude")]
    public class DataSafeTargetDatabaseGroupMatchingCriteriaInclude : oci.DataSafeTargetDatabaseGroup.IDataSafeTargetDatabaseGroupMatchingCriteriaInclude
    {
        private object? _compartments;

        /// <summary>compartments block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_group#compartments DataSafeTargetDatabaseGroup#compartments}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "compartments", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataSafeTargetDatabaseGroup.DataSafeTargetDatabaseGroupMatchingCriteriaIncludeCompartments\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Compartments
        {
            get => _compartments;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DataSafeTargetDatabaseGroup.IDataSafeTargetDatabaseGroupMatchingCriteriaIncludeCompartments[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataSafeTargetDatabaseGroup.IDataSafeTargetDatabaseGroupMatchingCriteriaIncludeCompartments).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _compartments = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_group#defined_tags DataSafeTargetDatabaseGroup#defined_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_group#freeform_tags DataSafeTargetDatabaseGroup#freeform_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_group#target_database_ids DataSafeTargetDatabaseGroup#target_database_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetDatabaseIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? TargetDatabaseIds
        {
            get;
            set;
        }
    }
}
