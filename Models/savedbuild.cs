namespace PrometheusAPI.Models
{
    public class SavedBuild
    {
        public int Id { get; set; }
        public int? CaseId { get; set; }
        public virtual Case Case { get; set; } = default!;
        public int? CoolerId { get; set; }
        public virtual Cooler Cooler { get; set; } = default!;
        public int? GraphicsCardId { get; set; }
        public virtual GraphicsCard GraphicsCard { get; set; } = default!;
        public int? HardDriveId { get; set; }
        public virtual HardDrive HardDrive { get; set; } = default!;
        public int? LoginId { get; set; }
        public virtual Login Login { get; set; } = default!;
        public int? MemoryId { get; set; }
        public virtual Memory Memory { get; set; } = default!;
        public int? MotherBoardId { get; set; }
        public virtual MotherBoard MotherBoard { get; set; } = default!;
        public int? OSId { get; set; }
        public virtual OS OS { get; set; } = default!;
        public int? PowerSupplyId { get; set; }
        public virtual PowerSupply PowerSupply { get; set; } = default!;
        public int? ProcessorId { get; set; }
        public virtual Processor Processor { get; set; } = default!;
    }
}