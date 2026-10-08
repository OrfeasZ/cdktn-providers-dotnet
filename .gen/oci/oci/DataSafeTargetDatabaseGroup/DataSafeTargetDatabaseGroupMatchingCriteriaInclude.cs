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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_target_database_group#compartments DataSafeTargetDatabaseGroup#compartments}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataSafeTargetDatabaseGroup.IDataSafeTargetDatabaseGroupMatchingCriteriaIncludeCompartments" />)[]</para>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_target_database_group#defined_tags DataSafeTargetDatabaseGroup#defined_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_target_database_group#freeform_tags DataSafeTargetDatabaseGroup#freeform_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get;
            set;
        }

        private object? _freeformTagsIn;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_target_database_group#freeform_tags_in DataSafeTargetDatabaseGroup#freeform_tags_in}.</summary>
        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, (string)[]&gt;</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "freeformTagsIn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
        public object? FreeformTagsIn
        {
            get => _freeformTagsIn;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case System.Collections.Generic.IDictionary<string, string[]> cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, string[]>; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _freeformTagsIn = value;
            }
        }

        private object? _systemTags;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_target_database_group#system_tags DataSafeTargetDatabaseGroup#system_tags}.</summary>
        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, (string)[]&gt;</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "systemTags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
        public object? SystemTags
        {
            get => _systemTags;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case System.Collections.Generic.IDictionary<string, string[]> cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, string[]>; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _systemTags = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_target_database_group#target_database_ids DataSafeTargetDatabaseGroup#target_database_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetDatabaseIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? TargetDatabaseIds
        {
            get;
            set;
        }
    }
}
