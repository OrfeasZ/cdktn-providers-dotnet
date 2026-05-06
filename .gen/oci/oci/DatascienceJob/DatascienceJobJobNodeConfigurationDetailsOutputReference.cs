using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceJob
{
    [JsiiClass(nativeType: typeof(oci.DatascienceJob.DatascienceJobJobNodeConfigurationDetailsOutputReference), fullyQualifiedName: "oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatascienceJobJobNodeConfigurationDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatascienceJobJobNodeConfigurationDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatascienceJobJobNodeConfigurationDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatascienceJobJobNodeConfigurationDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putJobNetworkConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNetworkConfiguration\"}}]")]
        public virtual void PutJobNetworkConfiguration(oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNetworkConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNetworkConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putJobNodeGroupConfigurationDetailsList", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListStruct\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutJobNodeGroupConfigurationDetailsList(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListStruct[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListStruct).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListStruct).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetJobNetworkConfiguration")]
        public virtual void ResetJobNetworkConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJobNodeGroupConfigurationDetailsList")]
        public virtual void ResetJobNodeGroupConfigurationDetailsList()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaximumRuntimeInMinutes")]
        public virtual void ResetMaximumRuntimeInMinutes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStartupOrder")]
        public virtual void ResetStartupOrder()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "jobNetworkConfiguration", typeJson: "{\"fqn\":\"oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNetworkConfigurationOutputReference\"}")]
        public virtual oci.DatascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNetworkConfigurationOutputReference JobNetworkConfiguration
        {
            get => GetInstanceProperty<oci.DatascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNetworkConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "jobNodeGroupConfigurationDetailsList", typeJson: "{\"fqn\":\"oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListStructList\"}")]
        public virtual oci.DatascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListStructList JobNodeGroupConfigurationDetailsList
        {
            get => GetInstanceProperty<oci.DatascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListStructList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "jobNetworkConfigurationInput", typeJson: "{\"fqn\":\"oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNetworkConfiguration\"}", isOptional: true)]
        public virtual oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNetworkConfiguration? JobNetworkConfigurationInput
        {
            get => GetInstanceProperty<oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNetworkConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jobNodeGroupConfigurationDetailsListInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListStruct\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? JobNodeGroupConfigurationDetailsListInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jobNodeTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? JobNodeTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumRuntimeInMinutesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MaximumRuntimeInMinutesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "startupOrderInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StartupOrderInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "jobNodeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobNodeType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maximumRuntimeInMinutes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaximumRuntimeInMinutes
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "startupOrder", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StartupOrder
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.datascienceJob.DatascienceJobJobNodeConfigurationDetails\"}", isOptional: true)]
        public virtual oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
