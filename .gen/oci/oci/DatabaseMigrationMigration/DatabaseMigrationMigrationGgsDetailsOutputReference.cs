using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseMigrationMigration
{
    [JsiiClass(nativeType: typeof(oci.DatabaseMigrationMigration.DatabaseMigrationMigrationGgsDetailsOutputReference), fullyQualifiedName: "oci.databaseMigrationMigration.DatabaseMigrationMigrationGgsDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatabaseMigrationMigrationGgsDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatabaseMigrationMigrationGgsDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatabaseMigrationMigrationGgsDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseMigrationMigrationGgsDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putExtract", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationGgsDetailsExtract\"}}]")]
        public virtual void PutExtract(oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationGgsDetailsExtract @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationGgsDetailsExtract)}, new object[]{@value});
        }

        [JsiiMethod(name: "putReplicat", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationGgsDetailsReplicat\"}}]")]
        public virtual void PutReplicat(oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationGgsDetailsReplicat @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationGgsDetailsReplicat)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAcceptableLag")]
        public virtual void ResetAcceptableLag()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExtract")]
        public virtual void ResetExtract()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReplicat")]
        public virtual void ResetReplicat()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "extract", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationGgsDetailsExtractOutputReference\"}")]
        public virtual oci.DatabaseMigrationMigration.DatabaseMigrationMigrationGgsDetailsExtractOutputReference Extract
        {
            get => GetInstanceProperty<oci.DatabaseMigrationMigration.DatabaseMigrationMigrationGgsDetailsExtractOutputReference>()!;
        }

        [JsiiProperty(name: "ggsDeployment", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationGgsDetailsGgsDeploymentList\"}")]
        public virtual oci.DatabaseMigrationMigration.DatabaseMigrationMigrationGgsDetailsGgsDeploymentList GgsDeployment
        {
            get => GetInstanceProperty<oci.DatabaseMigrationMigration.DatabaseMigrationMigrationGgsDetailsGgsDeploymentList>()!;
        }

        [JsiiProperty(name: "replicat", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationGgsDetailsReplicatOutputReference\"}")]
        public virtual oci.DatabaseMigrationMigration.DatabaseMigrationMigrationGgsDetailsReplicatOutputReference Replicat
        {
            get => GetInstanceProperty<oci.DatabaseMigrationMigration.DatabaseMigrationMigrationGgsDetailsReplicatOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "acceptableLagInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AcceptableLagInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "extractInput", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationGgsDetailsExtract\"}", isOptional: true)]
        public virtual oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationGgsDetailsExtract? ExtractInput
        {
            get => GetInstanceProperty<oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationGgsDetailsExtract?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicatInput", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationGgsDetailsReplicat\"}", isOptional: true)]
        public virtual oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationGgsDetailsReplicat? ReplicatInput
        {
            get => GetInstanceProperty<oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationGgsDetailsReplicat?>();
        }

        [JsiiProperty(name: "acceptableLag", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AcceptableLag
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationGgsDetails\"}", isOptional: true)]
        public virtual oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationGgsDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationGgsDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
