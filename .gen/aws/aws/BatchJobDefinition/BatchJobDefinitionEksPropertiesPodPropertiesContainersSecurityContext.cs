using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BatchJobDefinition
{
    [JsiiByValue(fqn: "aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesContainersSecurityContext")]
    public class BatchJobDefinitionEksPropertiesPodPropertiesContainersSecurityContext : aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesContainersSecurityContext
    {
        private object? _allowPrivilegeEscalation;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/batch_job_definition#allow_privilege_escalation BatchJobDefinition#allow_privilege_escalation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowPrivilegeEscalation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AllowPrivilegeEscalation
        {
            get => _allowPrivilegeEscalation;
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _allowPrivilegeEscalation = value;
            }
        }

        private object? _privileged;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/batch_job_definition#privileged BatchJobDefinition#privileged}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privileged", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Privileged
        {
            get => _privileged;
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _privileged = value;
            }
        }

        private object? _readOnlyRootFileSystem;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/batch_job_definition#read_only_root_file_system BatchJobDefinition#read_only_root_file_system}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "readOnlyRootFileSystem", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ReadOnlyRootFileSystem
        {
            get => _readOnlyRootFileSystem;
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _readOnlyRootFileSystem = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/batch_job_definition#run_as_group BatchJobDefinition#run_as_group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "runAsGroup", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RunAsGroup
        {
            get;
            set;
        }

        private object? _runAsNonRoot;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/batch_job_definition#run_as_non_root BatchJobDefinition#run_as_non_root}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "runAsNonRoot", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? RunAsNonRoot
        {
            get => _runAsNonRoot;
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _runAsNonRoot = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/batch_job_definition#run_as_user BatchJobDefinition#run_as_user}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "runAsUser", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RunAsUser
        {
            get;
            set;
        }
    }
}
