using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudGuardDataSource
{
    [JsiiClass(nativeType: typeof(oci.CloudGuardDataSource.CloudGuardDataSourceDataSourceDetailsOutputReference), fullyQualifiedName: "oci.cloudGuardDataSource.CloudGuardDataSourceDataSourceDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CloudGuardDataSourceDataSourceDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CloudGuardDataSourceDataSourceDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CloudGuardDataSourceDataSourceDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudGuardDataSourceDataSourceDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLoggingQueryDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.cloudGuardDataSource.CloudGuardDataSourceDataSourceDetailsLoggingQueryDetails\"}}]")]
        public virtual void PutLoggingQueryDetails(oci.CloudGuardDataSource.ICloudGuardDataSourceDataSourceDetailsLoggingQueryDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CloudGuardDataSource.ICloudGuardDataSourceDataSourceDetailsLoggingQueryDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putQueryStartTime", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.cloudGuardDataSource.CloudGuardDataSourceDataSourceDetailsQueryStartTime\"}}]")]
        public virtual void PutQueryStartTime(oci.CloudGuardDataSource.ICloudGuardDataSourceDataSourceDetailsQueryStartTime @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CloudGuardDataSource.ICloudGuardDataSourceDataSourceDetailsQueryStartTime)}, new object[]{@value});
        }

        [JsiiMethod(name: "putScheduledQueryScopeDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudGuardDataSource.CloudGuardDataSourceDataSourceDetailsScheduledQueryScopeDetails\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutScheduledQueryScopeDetails(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.CloudGuardDataSource.ICloudGuardDataSourceDataSourceDetailsScheduledQueryScopeDetails[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CloudGuardDataSource.ICloudGuardDataSourceDataSourceDetailsScheduledQueryScopeDetails).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CloudGuardDataSource.ICloudGuardDataSourceDataSourceDetailsScheduledQueryScopeDetails).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdditionalEntitiesCount")]
        public virtual void ResetAdditionalEntitiesCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIntervalInMinutes")]
        public virtual void ResetIntervalInMinutes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIntervalInSeconds")]
        public virtual void ResetIntervalInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoggingQueryDetails")]
        public virtual void ResetLoggingQueryDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoggingQueryType")]
        public virtual void ResetLoggingQueryType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOperator")]
        public virtual void ResetOperator()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQuery")]
        public virtual void ResetQuery()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQueryStartTime")]
        public virtual void ResetQueryStartTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegions")]
        public virtual void ResetRegions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScheduledQueryScopeDetails")]
        public virtual void ResetScheduledQueryScopeDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThreshold")]
        public virtual void ResetThreshold()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "loggingQueryDetails", typeJson: "{\"fqn\":\"oci.cloudGuardDataSource.CloudGuardDataSourceDataSourceDetailsLoggingQueryDetailsOutputReference\"}")]
        public virtual oci.CloudGuardDataSource.CloudGuardDataSourceDataSourceDetailsLoggingQueryDetailsOutputReference LoggingQueryDetails
        {
            get => GetInstanceProperty<oci.CloudGuardDataSource.CloudGuardDataSourceDataSourceDetailsLoggingQueryDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "queryStartTime", typeJson: "{\"fqn\":\"oci.cloudGuardDataSource.CloudGuardDataSourceDataSourceDetailsQueryStartTimeOutputReference\"}")]
        public virtual oci.CloudGuardDataSource.CloudGuardDataSourceDataSourceDetailsQueryStartTimeOutputReference QueryStartTime
        {
            get => GetInstanceProperty<oci.CloudGuardDataSource.CloudGuardDataSourceDataSourceDetailsQueryStartTimeOutputReference>()!;
        }

        [JsiiProperty(name: "scheduledQueryScopeDetails", typeJson: "{\"fqn\":\"oci.cloudGuardDataSource.CloudGuardDataSourceDataSourceDetailsScheduledQueryScopeDetailsList\"}")]
        public virtual oci.CloudGuardDataSource.CloudGuardDataSourceDataSourceDetailsScheduledQueryScopeDetailsList ScheduledQueryScopeDetails
        {
            get => GetInstanceProperty<oci.CloudGuardDataSource.CloudGuardDataSourceDataSourceDetailsScheduledQueryScopeDetailsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "additionalEntitiesCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AdditionalEntitiesCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataSourceFeedProviderInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DataSourceFeedProviderInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "intervalInMinutesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? IntervalInMinutesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "intervalInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? IntervalInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loggingQueryDetailsInput", typeJson: "{\"fqn\":\"oci.cloudGuardDataSource.CloudGuardDataSourceDataSourceDetailsLoggingQueryDetails\"}", isOptional: true)]
        public virtual oci.CloudGuardDataSource.ICloudGuardDataSourceDataSourceDetailsLoggingQueryDetails? LoggingQueryDetailsInput
        {
            get => GetInstanceProperty<oci.CloudGuardDataSource.ICloudGuardDataSourceDataSourceDetailsLoggingQueryDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loggingQueryTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LoggingQueryTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "operatorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OperatorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? QueryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryStartTimeInput", typeJson: "{\"fqn\":\"oci.cloudGuardDataSource.CloudGuardDataSourceDataSourceDetailsQueryStartTime\"}", isOptional: true)]
        public virtual oci.CloudGuardDataSource.ICloudGuardDataSourceDataSourceDetailsQueryStartTime? QueryStartTimeInput
        {
            get => GetInstanceProperty<oci.CloudGuardDataSource.ICloudGuardDataSourceDataSourceDetailsQueryStartTime?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? RegionsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scheduledQueryScopeDetailsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudGuardDataSource.CloudGuardDataSourceDataSourceDetailsScheduledQueryScopeDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ScheduledQueryScopeDetailsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "thresholdInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ThresholdInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "additionalEntitiesCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AdditionalEntitiesCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dataSourceFeedProvider", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataSourceFeedProvider
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "intervalInMinutes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IntervalInMinutes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "intervalInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IntervalInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "loggingQueryType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LoggingQueryType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Operator
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Query
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "regions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Regions
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "threshold", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Threshold
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.cloudGuardDataSource.CloudGuardDataSourceDataSourceDetails\"}", isOptional: true)]
        public virtual oci.CloudGuardDataSource.ICloudGuardDataSourceDataSourceDetails? InternalValue
        {
            get => GetInstanceProperty<oci.CloudGuardDataSource.ICloudGuardDataSourceDataSourceDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
