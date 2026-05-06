using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareWorkerVersions
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultMigrationsOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultMigrationsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareWorkerVersionsResultMigrationsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareWorkerVersionsResultMigrationsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareWorkerVersionsResultMigrationsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareWorkerVersionsResultMigrationsOutputReference(DeputyProps props): base(props)
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

        [JsiiProperty(name: "renamedClasses", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultMigrationsRenamedClassesList\"}")]
        public virtual cloudflare.DataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultMigrationsRenamedClassesList RenamedClasses
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultMigrationsRenamedClassesList>()!;
        }

        [JsiiProperty(name: "steps", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultMigrationsStepsList\"}")]
        public virtual cloudflare.DataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultMigrationsStepsList Steps
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultMigrationsStepsList>()!;
        }

        [JsiiProperty(name: "transferredClasses", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultMigrationsTransferredClassesList\"}")]
        public virtual cloudflare.DataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultMigrationsTransferredClassesList TransferredClasses
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultMigrationsTransferredClassesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkerVersions.DataCloudflareWorkerVersionsResultMigrations\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareWorkerVersions.IDataCloudflareWorkerVersionsResultMigrations? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkerVersions.IDataCloudflareWorkerVersionsResultMigrations?>();
            set => SetInstanceProperty(value);
        }
    }
}
