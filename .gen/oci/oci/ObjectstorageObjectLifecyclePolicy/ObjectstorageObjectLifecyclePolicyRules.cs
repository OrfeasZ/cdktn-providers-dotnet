using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ObjectstorageObjectLifecyclePolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.objectstorageObjectLifecyclePolicy.ObjectstorageObjectLifecyclePolicyRules")]
    public class ObjectstorageObjectLifecyclePolicyRules : oci.ObjectstorageObjectLifecyclePolicy.IObjectstorageObjectLifecyclePolicyRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/objectstorage_object_lifecycle_policy#action ObjectstorageObjectLifecyclePolicy#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public string Action
        {
            get;
            set;
        }

        private object _isEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/objectstorage_object_lifecycle_policy#is_enabled ObjectstorageObjectLifecyclePolicy#is_enabled}.</summary>
        [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object IsEnabled
        {
            get => _isEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/objectstorage_object_lifecycle_policy#name ObjectstorageObjectLifecyclePolicy#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/objectstorage_object_lifecycle_policy#time_amount ObjectstorageObjectLifecyclePolicy#time_amount}.</summary>
        [JsiiProperty(name: "timeAmount", typeJson: "{\"primitive\":\"string\"}")]
        public string TimeAmount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/objectstorage_object_lifecycle_policy#time_unit ObjectstorageObjectLifecyclePolicy#time_unit}.</summary>
        [JsiiProperty(name: "timeUnit", typeJson: "{\"primitive\":\"string\"}")]
        public string TimeUnit
        {
            get;
            set;
        }

        /// <summary>object_name_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/objectstorage_object_lifecycle_policy#object_name_filter ObjectstorageObjectLifecyclePolicy#object_name_filter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "objectNameFilter", typeJson: "{\"fqn\":\"oci.objectstorageObjectLifecyclePolicy.ObjectstorageObjectLifecyclePolicyRulesObjectNameFilter\"}", isOptional: true)]
        public oci.ObjectstorageObjectLifecyclePolicy.IObjectstorageObjectLifecyclePolicyRulesObjectNameFilter? ObjectNameFilter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/objectstorage_object_lifecycle_policy#target ObjectstorageObjectLifecyclePolicy#target}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Target
        {
            get;
            set;
        }
    }
}
