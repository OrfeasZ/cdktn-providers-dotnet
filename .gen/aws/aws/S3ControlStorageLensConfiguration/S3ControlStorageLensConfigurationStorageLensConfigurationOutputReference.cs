using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3ControlStorageLensConfiguration
{
    [JsiiClass(nativeType: typeof(aws.S3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationOutputReference), fullyQualifiedName: "aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class S3ControlStorageLensConfigurationStorageLensConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public S3ControlStorageLensConfigurationStorageLensConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3ControlStorageLensConfigurationStorageLensConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3ControlStorageLensConfigurationStorageLensConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAccountLevel", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationAccountLevel\"}}]")]
        public virtual void PutAccountLevel(aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationAccountLevel @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationAccountLevel)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAwsOrg", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationAwsOrg\"}}]")]
        public virtual void PutAwsOrg(aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationAwsOrg @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationAwsOrg)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDataExport", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationDataExport\"}}]")]
        public virtual void PutDataExport(aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationDataExport @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationDataExport)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExclude", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationExclude\"}}]")]
        public virtual void PutExclude(aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationExclude @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationExclude)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExpandedPrefixesDataExport", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExport\"}}]")]
        public virtual void PutExpandedPrefixesDataExport(aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExport @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExport)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInclude", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationInclude\"}}]")]
        public virtual void PutInclude(aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationInclude @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationInclude)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAwsOrg")]
        public virtual void ResetAwsOrg()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDataExport")]
        public virtual void ResetDataExport()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExclude")]
        public virtual void ResetExclude()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExpandedPrefixesDataExport")]
        public virtual void ResetExpandedPrefixesDataExport()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInclude")]
        public virtual void ResetInclude()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrefixDelimiter")]
        public virtual void ResetPrefixDelimiter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "accountLevel", typeJson: "{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationAccountLevelOutputReference\"}")]
        public virtual aws.S3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationAccountLevelOutputReference AccountLevel
        {
            get => GetInstanceProperty<aws.S3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationAccountLevelOutputReference>()!;
        }

        [JsiiProperty(name: "awsOrg", typeJson: "{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationAwsOrgOutputReference\"}")]
        public virtual aws.S3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationAwsOrgOutputReference AwsOrg
        {
            get => GetInstanceProperty<aws.S3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationAwsOrgOutputReference>()!;
        }

        [JsiiProperty(name: "dataExport", typeJson: "{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationDataExportOutputReference\"}")]
        public virtual aws.S3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationDataExportOutputReference DataExport
        {
            get => GetInstanceProperty<aws.S3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationDataExportOutputReference>()!;
        }

        [JsiiProperty(name: "exclude", typeJson: "{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationExcludeOutputReference\"}")]
        public virtual aws.S3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationExcludeOutputReference Exclude
        {
            get => GetInstanceProperty<aws.S3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationExcludeOutputReference>()!;
        }

        [JsiiProperty(name: "expandedPrefixesDataExport", typeJson: "{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportOutputReference\"}")]
        public virtual aws.S3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportOutputReference ExpandedPrefixesDataExport
        {
            get => GetInstanceProperty<aws.S3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExportOutputReference>()!;
        }

        [JsiiProperty(name: "include", typeJson: "{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationIncludeOutputReference\"}")]
        public virtual aws.S3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationIncludeOutputReference Include
        {
            get => GetInstanceProperty<aws.S3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationIncludeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountLevelInput", typeJson: "{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationAccountLevel\"}", isOptional: true)]
        public virtual aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationAccountLevel? AccountLevelInput
        {
            get => GetInstanceProperty<aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationAccountLevel?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "awsOrgInput", typeJson: "{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationAwsOrg\"}", isOptional: true)]
        public virtual aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationAwsOrg? AwsOrgInput
        {
            get => GetInstanceProperty<aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationAwsOrg?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataExportInput", typeJson: "{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationDataExport\"}", isOptional: true)]
        public virtual aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationDataExport? DataExportInput
        {
            get => GetInstanceProperty<aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationDataExport?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "excludeInput", typeJson: "{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationExclude\"}", isOptional: true)]
        public virtual aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationExclude? ExcludeInput
        {
            get => GetInstanceProperty<aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationExclude?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "expandedPrefixesDataExportInput", typeJson: "{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExport\"}", isOptional: true)]
        public virtual aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExport? ExpandedPrefixesDataExportInput
        {
            get => GetInstanceProperty<aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationExpandedPrefixesDataExport?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "includeInput", typeJson: "{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfigurationInclude\"}", isOptional: true)]
        public virtual aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationInclude? IncludeInput
        {
            get => GetInstanceProperty<aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfigurationInclude?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "prefixDelimiterInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrefixDelimiterInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Enabled
        {
            get => GetInstanceProperty<object>()!;
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
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "prefixDelimiter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrefixDelimiter
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.s3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfiguration\"}", isOptional: true)]
        public virtual aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.S3ControlStorageLensConfiguration.IS3ControlStorageLensConfigurationStorageLensConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
