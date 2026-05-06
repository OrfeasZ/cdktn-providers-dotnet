using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseMigrationMigration
{
    [JsiiClass(nativeType: typeof(oci.DatabaseMigrationMigration.DatabaseMigrationMigrationGgsDetailsExtractOutputReference), fullyQualifiedName: "oci.databaseMigrationMigration.DatabaseMigrationMigrationGgsDetailsExtractOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatabaseMigrationMigrationGgsDetailsExtractOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatabaseMigrationMigrationGgsDetailsExtractOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatabaseMigrationMigrationGgsDetailsExtractOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseMigrationMigrationGgsDetailsExtractOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetLongTransDuration")]
        public virtual void ResetLongTransDuration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPerformanceProfile")]
        public virtual void ResetPerformanceProfile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "longTransDurationInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? LongTransDurationInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "performanceProfileInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PerformanceProfileInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "longTransDuration", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LongTransDuration
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "performanceProfile", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PerformanceProfile
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationGgsDetailsExtract\"}", isOptional: true)]
        public virtual oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationGgsDetailsExtract? InternalValue
        {
            get => GetInstanceProperty<oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationGgsDetailsExtract?>();
            set => SetInstanceProperty(value);
        }
    }
}
