using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DifStack
{
    [JsiiClass(nativeType: typeof(oci.DifStack.DifStackDataflowOutputReference), fullyQualifiedName: "oci.difStack.DifStackDataflowOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DifStackDataflowOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DifStackDataflowOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DifStackDataflowOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DifStackDataflowOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putConnections", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.difStack.DifStackDataflowConnections\"}}]")]
        public virtual void PutConnections(oci.DifStack.IDifStackDataflowConnections @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DifStack.IDifStackDataflowConnections)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDriverShapeConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.difStack.DifStackDataflowDriverShapeConfig\"}}]")]
        public virtual void PutDriverShapeConfig(oci.DifStack.IDifStackDataflowDriverShapeConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DifStack.IDifStackDataflowDriverShapeConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExecutorShapeConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.difStack.DifStackDataflowExecutorShapeConfig\"}}]")]
        public virtual void PutExecutorShapeConfig(oci.DifStack.IDifStackDataflowExecutorShapeConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DifStack.IDifStackDataflowExecutorShapeConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetArchiveUri")]
        public virtual void ResetArchiveUri()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConnections")]
        public virtual void ResetConnections()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDriverShapeConfig")]
        public virtual void ResetDriverShapeConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExecute")]
        public virtual void ResetExecute()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExecutorShapeConfig")]
        public virtual void ResetExecutorShapeConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrivateEndpointId")]
        public virtual void ResetPrivateEndpointId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWarehouseBucketInstanceId")]
        public virtual void ResetWarehouseBucketInstanceId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "connections", typeJson: "{\"fqn\":\"oci.difStack.DifStackDataflowConnectionsOutputReference\"}")]
        public virtual oci.DifStack.DifStackDataflowConnectionsOutputReference Connections
        {
            get => GetInstanceProperty<oci.DifStack.DifStackDataflowConnectionsOutputReference>()!;
        }

        [JsiiProperty(name: "driverShapeConfig", typeJson: "{\"fqn\":\"oci.difStack.DifStackDataflowDriverShapeConfigOutputReference\"}")]
        public virtual oci.DifStack.DifStackDataflowDriverShapeConfigOutputReference DriverShapeConfig
        {
            get => GetInstanceProperty<oci.DifStack.DifStackDataflowDriverShapeConfigOutputReference>()!;
        }

        [JsiiProperty(name: "executorShapeConfig", typeJson: "{\"fqn\":\"oci.difStack.DifStackDataflowExecutorShapeConfigOutputReference\"}")]
        public virtual oci.DifStack.DifStackDataflowExecutorShapeConfigOutputReference ExecutorShapeConfig
        {
            get => GetInstanceProperty<oci.DifStack.DifStackDataflowExecutorShapeConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "archiveUriInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ArchiveUriInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionsInput", typeJson: "{\"fqn\":\"oci.difStack.DifStackDataflowConnections\"}", isOptional: true)]
        public virtual oci.DifStack.IDifStackDataflowConnections? ConnectionsInput
        {
            get => GetInstanceProperty<oci.DifStack.IDifStackDataflowConnections?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "driverShapeConfigInput", typeJson: "{\"fqn\":\"oci.difStack.DifStackDataflowDriverShapeConfig\"}", isOptional: true)]
        public virtual oci.DifStack.IDifStackDataflowDriverShapeConfig? DriverShapeConfigInput
        {
            get => GetInstanceProperty<oci.DifStack.IDifStackDataflowDriverShapeConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "driverShapeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DriverShapeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "executeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExecuteInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "executorShapeConfigInput", typeJson: "{\"fqn\":\"oci.difStack.DifStackDataflowExecutorShapeConfig\"}", isOptional: true)]
        public virtual oci.DifStack.IDifStackDataflowExecutorShapeConfig? ExecutorShapeConfigInput
        {
            get => GetInstanceProperty<oci.DifStack.IDifStackDataflowExecutorShapeConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "executorShapeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExecutorShapeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logBucketInstanceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LogBucketInstanceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "numExecutorsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NumExecutorsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateEndpointIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrivateEndpointIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sparkVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SparkVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "warehouseBucketInstanceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WarehouseBucketInstanceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "archiveUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ArchiveUri
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "driverShape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DriverShape
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "execute", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Execute
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "executorShape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExecutorShape
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "logBucketInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogBucketInstanceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "numExecutors", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumExecutors
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "privateEndpointId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateEndpointId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sparkVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SparkVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "warehouseBucketInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WarehouseBucketInstanceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.DifStack.IDifStackDataflow" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.difStack.DifStackDataflow\"}]}}", isOptional: true)]
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
                        case oci.DifStack.IDifStackDataflow cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DifStack.IDifStackDataflow).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
