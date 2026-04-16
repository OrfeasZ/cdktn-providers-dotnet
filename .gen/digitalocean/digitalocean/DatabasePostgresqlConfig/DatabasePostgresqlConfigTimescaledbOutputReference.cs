using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DatabasePostgresqlConfig
{
    [JsiiClass(nativeType: typeof(digitalocean.DatabasePostgresqlConfig.DatabasePostgresqlConfigTimescaledbOutputReference), fullyQualifiedName: "digitalocean.databasePostgresqlConfig.DatabasePostgresqlConfigTimescaledbOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatabasePostgresqlConfigTimescaledbOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatabasePostgresqlConfigTimescaledbOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatabasePostgresqlConfigTimescaledbOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabasePostgresqlConfigTimescaledbOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetMaxBackgroundWorkers")]
        public virtual void ResetMaxBackgroundWorkers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxBackgroundWorkersInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxBackgroundWorkersInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "maxBackgroundWorkers", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxBackgroundWorkers
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"digitalocean.databasePostgresqlConfig.DatabasePostgresqlConfigTimescaledb\"}", isOptional: true)]
        public virtual digitalocean.DatabasePostgresqlConfig.IDatabasePostgresqlConfigTimescaledb? InternalValue
        {
            get => GetInstanceProperty<digitalocean.DatabasePostgresqlConfig.IDatabasePostgresqlConfigTimescaledb?>();
            set => SetInstanceProperty(value);
        }
    }
}
