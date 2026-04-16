using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace neon.Project
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "neon.project.ProjectMaintenanceWindow")]
    public class ProjectMaintenanceWindow : neon.Project.IProjectMaintenanceWindow
    {
        /// <summary>End time of the maintenance window, in the format of "HH:MM". Uses UTC.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#end_time Project#end_time}
        /// </remarks>
        [JsiiProperty(name: "endTime", typeJson: "{\"primitive\":\"string\"}")]
        public string EndTime
        {
            get;
            set;
        }

        /// <summary>Start time of the maintenance window, in the format of "HH:MM". Uses UTC.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#start_time Project#start_time}
        /// </remarks>
        [JsiiProperty(name: "startTime", typeJson: "{\"primitive\":\"string\"}")]
        public string StartTime
        {
            get;
            set;
        }

        /// <summary>A list of weekdays when the maintenance window is active.</summary>
        /// <remarks>
        /// Encoded as ints, where 1 - Monday, and 7 - Sunday.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#weekdays Project#weekdays}
        /// </remarks>
        [JsiiProperty(name: "weekdays", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public double[] Weekdays
        {
            get;
            set;
        }
    }
}
