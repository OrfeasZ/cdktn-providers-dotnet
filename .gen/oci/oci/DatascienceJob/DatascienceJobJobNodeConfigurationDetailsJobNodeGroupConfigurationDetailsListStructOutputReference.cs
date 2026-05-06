using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceJob
{
    [JsiiClass(nativeType: typeof(oci.DatascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListStructOutputReference), fullyQualifiedName: "oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListStructOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListStructOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListStructOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListStructOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListStructOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putJobConfigurationDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobConfigurationDetails\"}}]")]
        public virtual void PutJobConfigurationDetails(oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobConfigurationDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobConfigurationDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putJobEnvironmentConfigurationDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobEnvironmentConfigurationDetails\"}}]")]
        public virtual void PutJobEnvironmentConfigurationDetails(oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobEnvironmentConfigurationDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobEnvironmentConfigurationDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putJobInfrastructureConfigurationDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetails\"}}]")]
        public virtual void PutJobInfrastructureConfigurationDetails(oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetJobConfigurationDetails")]
        public virtual void ResetJobConfigurationDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJobEnvironmentConfigurationDetails")]
        public virtual void ResetJobEnvironmentConfigurationDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJobInfrastructureConfigurationDetails")]
        public virtual void ResetJobInfrastructureConfigurationDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinimumSuccessReplicas")]
        public virtual void ResetMinimumSuccessReplicas()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReplicas")]
        public virtual void ResetReplicas()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "jobConfigurationDetails", typeJson: "{\"fqn\":\"oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobConfigurationDetailsOutputReference\"}")]
        public virtual oci.DatascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobConfigurationDetailsOutputReference JobConfigurationDetails
        {
            get => GetInstanceProperty<oci.DatascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobConfigurationDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "jobEnvironmentConfigurationDetails", typeJson: "{\"fqn\":\"oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobEnvironmentConfigurationDetailsOutputReference\"}")]
        public virtual oci.DatascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobEnvironmentConfigurationDetailsOutputReference JobEnvironmentConfigurationDetails
        {
            get => GetInstanceProperty<oci.DatascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobEnvironmentConfigurationDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "jobInfrastructureConfigurationDetails", typeJson: "{\"fqn\":\"oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsOutputReference\"}")]
        public virtual oci.DatascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsOutputReference JobInfrastructureConfigurationDetails
        {
            get => GetInstanceProperty<oci.DatascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "jobConfigurationDetailsInput", typeJson: "{\"fqn\":\"oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobConfigurationDetails\"}", isOptional: true)]
        public virtual oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobConfigurationDetails? JobConfigurationDetailsInput
        {
            get => GetInstanceProperty<oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobConfigurationDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jobEnvironmentConfigurationDetailsInput", typeJson: "{\"fqn\":\"oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobEnvironmentConfigurationDetails\"}", isOptional: true)]
        public virtual oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobEnvironmentConfigurationDetails? JobEnvironmentConfigurationDetailsInput
        {
            get => GetInstanceProperty<oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobEnvironmentConfigurationDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jobInfrastructureConfigurationDetailsInput", typeJson: "{\"fqn\":\"oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetails\"}", isOptional: true)]
        public virtual oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetails? JobInfrastructureConfigurationDetailsInput
        {
            get => GetInstanceProperty<oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minimumSuccessReplicasInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinimumSuccessReplicasInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicasInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ReplicasInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "minimumSuccessReplicas", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinimumSuccessReplicas
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "replicas", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Replicas
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListStruct\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListStruct cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListStruct).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
