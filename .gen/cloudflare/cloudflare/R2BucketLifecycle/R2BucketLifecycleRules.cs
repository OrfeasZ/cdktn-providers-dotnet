using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.R2BucketLifecycle
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.r2BucketLifecycle.R2BucketLifecycleRules")]
    public class R2BucketLifecycleRules : cloudflare.R2BucketLifecycle.IR2BucketLifecycleRules
    {
        /// <summary>Conditions that apply to all transitions of this rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/r2_bucket_lifecycle#conditions R2BucketLifecycle#conditions}
        /// </remarks>
        [JsiiProperty(name: "conditions", typeJson: "{\"fqn\":\"cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesConditions\"}")]
        public cloudflare.R2BucketLifecycle.IR2BucketLifecycleRulesConditions Conditions
        {
            get;
            set;
        }

        private object _enabled;

        /// <summary>Whether or not this rule is in effect.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/r2_bucket_lifecycle#enabled R2BucketLifecycle#enabled}
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object Enabled
        {
            get => _enabled;
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
                _enabled = value;
            }
        }

        /// <summary>Unique identifier for this rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/r2_bucket_lifecycle#id R2BucketLifecycle#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public string Id
        {
            get;
            set;
        }

        /// <summary>Transition to abort ongoing multipart uploads.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/r2_bucket_lifecycle#abort_multipart_uploads_transition R2BucketLifecycle#abort_multipart_uploads_transition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "abortMultipartUploadsTransition", typeJson: "{\"fqn\":\"cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesAbortMultipartUploadsTransition\"}", isOptional: true)]
        public cloudflare.R2BucketLifecycle.IR2BucketLifecycleRulesAbortMultipartUploadsTransition? AbortMultipartUploadsTransition
        {
            get;
            set;
        }

        /// <summary>Transition to delete objects.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/r2_bucket_lifecycle#delete_objects_transition R2BucketLifecycle#delete_objects_transition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deleteObjectsTransition", typeJson: "{\"fqn\":\"cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesDeleteObjectsTransition\"}", isOptional: true)]
        public cloudflare.R2BucketLifecycle.IR2BucketLifecycleRulesDeleteObjectsTransition? DeleteObjectsTransition
        {
            get;
            set;
        }

        private object? _storageClassTransitions;

        /// <summary>Transitions to change the storage class of objects.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/r2_bucket_lifecycle#storage_class_transitions R2BucketLifecycle#storage_class_transitions}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "storageClassTransitions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesStorageClassTransitions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? StorageClassTransitions
        {
            get => _storageClassTransitions;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.R2BucketLifecycle.IR2BucketLifecycleRulesStorageClassTransitions[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.R2BucketLifecycle.IR2BucketLifecycleRulesStorageClassTransitions).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _storageClassTransitions = value;
            }
        }
    }
}
