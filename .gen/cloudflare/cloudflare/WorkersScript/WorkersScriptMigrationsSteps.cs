using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkersScript
{
    [JsiiByValue(fqn: "cloudflare.workersScript.WorkersScriptMigrationsSteps")]
    public class WorkersScriptMigrationsSteps : cloudflare.WorkersScript.IWorkersScriptMigrationsSteps
    {
        /// <summary>A list of classes to delete Durable Object namespaces from.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/workers_script#deleted_classes WorkersScript#deleted_classes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deletedClasses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? DeletedClasses
        {
            get;
            set;
        }

        /// <summary>A list of classes to create Durable Object namespaces from.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/workers_script#new_classes WorkersScript#new_classes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "newClasses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? NewClasses
        {
            get;
            set;
        }

        /// <summary>A list of classes to create Durable Object namespaces with SQLite from.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/workers_script#new_sqlite_classes WorkersScript#new_sqlite_classes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "newSqliteClasses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? NewSqliteClasses
        {
            get;
            set;
        }

        private object? _renamedClasses;

        /// <summary>A list of classes with Durable Object namespaces that were renamed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/workers_script#renamed_classes WorkersScript#renamed_classes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "renamedClasses", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.workersScript.WorkersScriptMigrationsStepsRenamedClasses\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RenamedClasses
        {
            get => _renamedClasses;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.WorkersScript.IWorkersScriptMigrationsStepsRenamedClasses[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.WorkersScript.IWorkersScriptMigrationsStepsRenamedClasses).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _renamedClasses = value;
            }
        }

        private object? _transferredClasses;

        /// <summary>A list of transfers for Durable Object namespaces from a different Worker and class to a class defined in this Worker.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/workers_script#transferred_classes WorkersScript#transferred_classes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "transferredClasses", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.workersScript.WorkersScriptMigrationsStepsTransferredClasses\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TransferredClasses
        {
            get => _transferredClasses;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.WorkersScript.IWorkersScriptMigrationsStepsTransferredClasses[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.WorkersScript.IWorkersScriptMigrationsStepsTransferredClasses).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _transferredClasses = value;
            }
        }
    }
}
