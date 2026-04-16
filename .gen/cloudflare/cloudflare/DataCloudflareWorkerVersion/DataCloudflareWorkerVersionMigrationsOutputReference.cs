using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareWorkerVersion
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareWorkerVersion.DataCloudflareWorkerVersionMigrationsOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareWorkerVersion.DataCloudflareWorkerVersionMigrationsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareWorkerVersionMigrationsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareWorkerVersionMigrationsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareWorkerVersionMigrationsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareWorkerVersionMigrationsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "deletedClasses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DeletedClasses
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "newClasses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NewClasses
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "newSqliteClasses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NewSqliteClasses
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "newTag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NewTag
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "oldTag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OldTag
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "renamedClasses", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkerVersion.DataCloudflareWorkerVersionMigrationsRenamedClassesList\"}")]
        public virtual cloudflare.DataCloudflareWorkerVersion.DataCloudflareWorkerVersionMigrationsRenamedClassesList RenamedClasses
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkerVersion.DataCloudflareWorkerVersionMigrationsRenamedClassesList>()!;
        }

        [JsiiProperty(name: "steps", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkerVersion.DataCloudflareWorkerVersionMigrationsStepsList\"}")]
        public virtual cloudflare.DataCloudflareWorkerVersion.DataCloudflareWorkerVersionMigrationsStepsList Steps
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkerVersion.DataCloudflareWorkerVersionMigrationsStepsList>()!;
        }

        [JsiiProperty(name: "transferredClasses", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkerVersion.DataCloudflareWorkerVersionMigrationsTransferredClassesList\"}")]
        public virtual cloudflare.DataCloudflareWorkerVersion.DataCloudflareWorkerVersionMigrationsTransferredClassesList TransferredClasses
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkerVersion.DataCloudflareWorkerVersionMigrationsTransferredClassesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkerVersion.DataCloudflareWorkerVersionMigrations\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareWorkerVersion.IDataCloudflareWorkerVersionMigrations? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkerVersion.IDataCloudflareWorkerVersionMigrations?>();
            set => SetInstanceProperty(value);
        }
    }
}
